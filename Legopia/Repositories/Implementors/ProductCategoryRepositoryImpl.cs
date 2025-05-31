using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class ProductCategoryRepositoryImpl : GenericRepositoryImpl<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
