using Legopia.Areas.Customer.Models;
using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Customer/Products")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = new ProductIndexViewModel
            {
                SidebarFilter = new ProductIndexViewModel.SidebarProductFilterViewModel
                {
                    SelectedFilters =
                    [
                        new FilterItemModel { Label = "Red", Count = 10, Selected = true }
                    ],
                    InStock = true,
                    ProductTypes =
                    [
                        new FilterItemModel { Label = "Brick", Count = 20, Selected = false },
                        new FilterItemModel { Label = "Plate", Count = 15, Selected = false }
                    ],
                    PriceRanges =
                    [
                        new FilterItemModel { Label = "$0 - $10", Count = 5, Selected = false },
                        new FilterItemModel { Label = "$10 - $20", Count = 8, Selected = false }
                    ]
                },
                Products = _productService.GetAll(),
            };

            return View(model);
        }

        [HttpGet("Detail/{id}")]
        public IActionResult Detail(int id)
        {
            var product = _productService.GetById(id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
