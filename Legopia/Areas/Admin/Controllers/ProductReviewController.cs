using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/ProductReviews")]
    public class ProductReviewController : Controller
    {
        private readonly IProductReviewService _productReviewService;

        public ProductReviewController(IProductReviewService productReviewService)
        {
            _productReviewService = productReviewService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
