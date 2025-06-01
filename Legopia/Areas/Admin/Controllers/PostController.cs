using Legopia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Posts")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
