using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("order_coupon_joining")]
    public class OrderCouponJoining
    {
        [ForeignKey(nameof(Order))]
        [Column("order_id")]
        public int? OrderId { get; set; }
        public OrderDetails? Order { get; set; }
        [ForeignKey(nameof(Coupon))]
        [Column("coupon_id")]
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
    }
}
