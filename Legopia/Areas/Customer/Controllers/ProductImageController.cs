using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var image = _productImageService.GetById(id);
            if (image == null || image.ImageData == null)
                return NotFound();

            return File(image.ImageData, "image/jpeg");
        }
    }
}
