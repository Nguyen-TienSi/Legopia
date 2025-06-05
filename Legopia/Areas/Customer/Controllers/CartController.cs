using Legopia.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Legopia.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }

            var cart = _cartService.GetCartByUserId(userId);
            return View(cart);
        }
    }
}
