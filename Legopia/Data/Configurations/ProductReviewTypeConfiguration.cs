using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Legopia.Data.Configurations
{
    public class ProductReviewTypeConfiguration : IEntityTypeConfiguration<ProductReview>
    {
        public void Configure(EntityTypeBuilder<ProductReview> builder)
        {

        }
    }
}
