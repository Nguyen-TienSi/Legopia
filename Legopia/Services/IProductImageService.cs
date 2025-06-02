using Legopia.Models.Entities;

namespace Legopia.Services
{
    public interface IProductImageService
    {
        IEnumerable<ProductImage> GetAll();

        ProductImage? GetById(int id);
    }
}
