using Legopia.Areas.Admin.Models;
using Legopia.Models.Entities;
using System.Collections.Generic;

namespace Legopia.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        void Add(ProductCreateViewModel viewModel);
    }
}
