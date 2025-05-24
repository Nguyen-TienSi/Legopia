using Legopia.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("coupons")]
    public class Coupon : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [Column("coupon_code")]
        public string CouponCode { get; set; } = string.Empty;
        [Column("discount_amount")]
        public decimal? DiscountAmount { get; set; }
        [Column("discount_percentage")]
        public float? DiscountPercentage { get; set; }
        [Column("minimum_order_amount")]
        public decimal? MinimumOrderAmount { get; set; }
        [Column("expiration_date")]
        public DateTime ExpirationDate { get; set; }
        [Column("coupon_status")]
        public CouponStatus CouponStatus { get; set; }
        [Column("usage_limit")]
        public int? UsageLimit { get; set; }
        [Column("used_count")]
        public int UsedCount { get; set; } = 0;
        // Many to many relationship
        public ICollection<OrderCouponJoining> OrderCouponJoinings { get; set; } = [];
    }
}
