using Legopia.Models.Entities;
using Legopia.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("Admin/Products")]
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return View(product);

            _productService.Add(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
