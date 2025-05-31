using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Legopia.Data.Configurations
{
    public class ProductImageJoiningTypeConfiguration : IEntityTypeConfiguration<ProductImageJoining>
    {
        public void Configure(EntityTypeBuilder<ProductImageJoining> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ProductImageId });
        }
    }
}
