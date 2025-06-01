using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Roles")]
    public class RoleController : Controller
    {
        private readonly IUserRoleService _userRoleService;

        public RoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var roles = await _userRoleService.GetAllAsync();
            return View(roles);
        }
    }
}
