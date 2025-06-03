using Legopia.Models.Identity;
using Legopia.Models.ViewModels;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Legopia.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserDetails> _userManager;
        private readonly SignInManager<UserDetails> _signInManager;
        private readonly RoleManager<UserRole> _roleManager;
        private readonly IDataProtector _dataProtector;
        private readonly string CREDENTIALS_KEY = "CredentialsToken";

        public AccountController(
            UserManager<UserDetails> userManager,
            SignInManager<UserDetails> signInManager,
            RoleManager<UserRole> roleManager,
            IDataProtectionProvider dataProtectionProvider)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _dataProtector = dataProtectionProvider.CreateProtector("Legopia.AccountController");
        }

        // Step 1: Register Account (Credentials)
        [HttpGet]
        public IActionResult RegisterCredentials()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterCredentials(RegistrationCredentialsViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Serialize and encrypt
            var json = JsonSerializer.Serialize(model);
            var token = _dataProtector.Protect(json);

            // Store token
            TempData[CREDENTIALS_KEY] = token;

            return RedirectToAction(nameof(RegisterPersonalInfo));
        }

        // Step 2: Register Personal Information
        [HttpGet]
        public IActionResult RegisterPersonalInfo()
        {
            if (TempData[CREDENTIALS_KEY] == null)
                return RedirectToAction(nameof(RegisterCredentials));

            TempData.Keep(CREDENTIALS_KEY);

            return View(new RegistrationPersonalInfoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterPersonalInfo(RegistrationPersonalInfoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (TempData[CREDENTIALS_KEY] is not string token)
                return RedirectToAction(nameof(RegisterCredentials));

            try
            {
                var json = _dataProtector.Unprotect(token);
                var credentials = JsonSerializer.Deserialize<RegistrationCredentialsViewModel>(json);

                var user = new UserDetails
                {
                    UserName = credentials!.UserName,
                    Email = credentials.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = await _userManager.CreateAsync(user, credentials.Password);
                if (result.Succeeded)
                {
                    var role = new UserRole { Name = "Customer" };
                    if (!await _roleManager.RoleExistsAsync(role.Name))
                        await _roleManager.CreateAsync(role);

                    await _userManager.AddToRoleAsync(user, role.Name);

                    await _signInManager.SignInAsync(user, false);

                    return await RedirectToLocal();
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Invalid or expired token.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            UserDetails? user = await _userManager.FindByNameAsync(model.UserNameOrEmail)
                ?? await _userManager.FindByEmailAsync(model.UserNameOrEmail);

            if (user == null || string.IsNullOrEmpty(user.UserName))
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(
                user.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return await RedirectToLocal("", user);
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return await RedirectToLocal();
        }

        public IActionResult Index()
        {
            return View();
        }

        private async Task<IActionResult> RedirectToLocal(string? returnUrl = null, UserDetails? user = null)
        {
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (roles.Contains("Admin"))
                {
                    return RedirectToRoute(new { area = "Admin", controller = "Home", action = "Index" });
                }
            }

            return RedirectToRoute(new { area = "Customer", controller = "Home", action = "Index" });
        }
    }
}
