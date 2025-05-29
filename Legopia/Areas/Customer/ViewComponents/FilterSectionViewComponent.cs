using Legopia.Areas.Customer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Legopia.Areas.Customer.ViewComponents
{
    public class FilterSectionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, IEnumerable<FilterItemModel> filters)
        {
            var model = new FilterSectionModel
            {
                Title = title,
                Filters = [.. filters],
            };
            return View(model);
        }
    }
}
