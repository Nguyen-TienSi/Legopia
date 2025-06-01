using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/PostCategories")]
    public class PostCategoryController : Controller
    {
        private readonly IPostCategoryService _postCategoryService;

        public PostCategoryController(IPostCategoryService postCategoryService)
        {
            _postCategoryService = postCategoryService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var categories = await _postCategoryService.GetAllAsync();
            return View(categories);
        }
    }
}
