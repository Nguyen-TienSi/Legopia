using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Legopia.Data.Configurations
{
    public class OrderCouponJoiningTypeConfiguration : IEntityTypeConfiguration<OrderCouponJoining>
    {
        public void Configure(EntityTypeBuilder<OrderCouponJoining> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.CouponId });
        }
    }
}
