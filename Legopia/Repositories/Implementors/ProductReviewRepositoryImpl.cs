using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class ProductReviewRepositoryImpl : GenericRepositoryImpl<ProductReview>, IProductReviewRepository
    {
        public ProductReviewRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
