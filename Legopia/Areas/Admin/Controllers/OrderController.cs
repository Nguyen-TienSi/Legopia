using Legopia.Models.Entities;
using Legopia.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legopia.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Orders")]
    public class OrderController : Controller
    {
        private readonly IOrderDetailsService _orderDetailsService;

        public OrderController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var orders = await _orderDetailsService.GetAllAsync();
            return View(orders);
        }
    }
}
