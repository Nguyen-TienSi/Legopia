using Legopia.Models.Entities;

namespace Legopia.Services
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategory>> GetAllAsync();
    }
}
