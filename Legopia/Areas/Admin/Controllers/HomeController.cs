using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Amin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
