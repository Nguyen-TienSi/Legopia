using Legopia.Models.Enums;
using Legopia.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("orders")]
    public class OrderDetails : BaseEntity
    {
        [Column("order_status")]
        public OrderStatus OrderStatus { get; set; }
        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        [Column("total_amount")]
        public decimal TotalAmount { get; set; }
        // One to one relationship
        [ForeignKey(nameof(Address))]
        [Column("shipping_address")]
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        // Many to one relationship
        [ForeignKey(nameof(UserDetails))]
        [Column("user_details_id")]
        public string? UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
        // One to many relationship
        public ICollection<OrderItem> OrderItems { get; set; } = [];
        // Many to many relationship
        public ICollection<OrderCouponJoining> OrderCouponJoinings { get; set; } = [];

        [NotMapped]
        public decimal FinalAmount => CalculateFinalAmount();

        private IEnumerable<Coupon> Coupons => OrderCouponJoinings?
            .Where(j => j.Coupon != null)
            .Select(j => j.Coupon!) ?? [];

        private decimal CalculateFinalAmount()
        {
            if (OrderCouponJoinings == null || OrderCouponJoinings.Count == 0)
                return TotalAmount;

            decimal amount = TotalAmount;
            decimal maxDiscount = 0;

            // Apply all percentage discounts sequentially
            foreach (var coupon in Coupons.Where(c => c.DiscountPercentage.HasValue && c.DiscountPercentage > 0))
            {
                amount -= amount * ((decimal)coupon.DiscountPercentage.GetValueOrDefault() / 100);
            }

            // Find the maximum fixed discount among all coupons
            foreach (var coupon in Coupons.Where(c => c.DiscountAmount.HasValue && c.DiscountAmount > 0))
            {
                if (coupon.DiscountAmount.GetValueOrDefault() > maxDiscount)
                    maxDiscount = coupon.DiscountAmount.GetValueOrDefault();
            }

            amount -= maxDiscount;

            return Math.Max(0, amount);
        }
    }
}
