using Legopia.Models.Identity;
using Legopia.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Roles")]
    public class RoleController : Controller
    {
        private readonly RoleManager<UserRole> _roleManager;

        public RoleController(RoleManager<UserRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserRole model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var role = new UserRole
            {
                Name = model.Name,
                Description = model.Description
            };

            IdentityResult result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
    }
}
