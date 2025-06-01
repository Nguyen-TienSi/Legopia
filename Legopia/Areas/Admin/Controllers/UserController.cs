using Legopia.Models.Identity;
using Legopia.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Users")]
    public class UserController : Controller
    {
        private readonly IUserDetailsService _userDetailsService;

        public UserController(IUserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var users = await _userDetailsService.GetAllAsync();
            return View(users);
        }
    }
}
