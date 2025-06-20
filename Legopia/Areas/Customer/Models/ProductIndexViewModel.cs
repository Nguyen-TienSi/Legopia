using Legopia.Models.Entities;
using System.Collections.Generic;

namespace Legopia.Areas.Customer.Models
{
    public class ProductIndexViewModel
    {
        public SidebarProductFilterViewModel SidebarFilter { get; set; } = new SidebarProductFilterViewModel();
        public IEnumerable<Product> Products { get; set; } = [];

        public class SidebarProductFilterViewModel
        {
            public ICollection<FilterItemModel> SelectedFilters { get; set; } = [];
            public bool InStock { get; set; }
            public ICollection<FilterItemModel> ProductTypes { get; set; } = [];
            public ICollection<FilterItemModel> PriceRanges { get; set; } = [];
        }
    }
}
