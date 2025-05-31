using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class ProductImageRepositoryImpl : GenericRepositoryImpl<ProductImage>, IProductImageRepository
    {
        public ProductImageRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
