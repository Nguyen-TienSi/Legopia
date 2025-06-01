using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly IOrderDetailsService _orderDetailsService;

        public OrderController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
