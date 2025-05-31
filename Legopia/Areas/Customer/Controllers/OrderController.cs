using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
