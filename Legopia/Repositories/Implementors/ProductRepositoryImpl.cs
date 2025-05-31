using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class ProductRepositoryImpl : GenericRepositoryImpl<Product>, IProductRepository
    {
        public ProductRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
