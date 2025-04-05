using Legopia.Models.Enums;
using Legopia.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public int? CouponId { get; set; }
        public Coupon Coupon { get; set; } // Mã giảm giá đã dùng

        public OrderStatus Status { get; set; } = OrderStatus.Pending; // Giá trị mặc định
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        [NotMapped] // Không lưu vào database
        public decimal FinalAmount => CalculateFinalAmount(); // Chỉ có getter, không có setter

        private decimal CalculateFinalAmount()
        {
            if (Coupon == null) return TotalAmount; // Kiểm tra null trước khi truy cập Coupon

            decimal discount = 0;

            if (Coupon.DiscountPercentage.HasValue && Coupon.DiscountPercentage > 0)
            {
                discount = TotalAmount * (decimal)Coupon.DiscountPercentage.Value / 100;
            }

            if (Coupon.DiscountAmount.HasValue && Coupon.DiscountAmount > 0)
            {
                discount = Math.Max(discount, Coupon.DiscountAmount.Value);
            }

            return Math.Max(0, TotalAmount - discount); // Đảm bảo giá trị không âm
        }
    }
}
