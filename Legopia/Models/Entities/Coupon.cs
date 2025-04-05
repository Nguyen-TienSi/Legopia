using System.ComponentModel.DataAnnotations;

namespace Legopia.Models.Entities
{
    public class Coupon
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } // Mã giảm giá (VD: "LEGO10")

        public decimal? DiscountAmount { get; set; } // Giảm giá theo số tiền (VD: 50k)
        public float? DiscountPercentage { get; set; } // Giảm giá theo % (VD: 10%)

        public decimal? MinimumOrderAmount { get; set; } // Đơn hàng tối thiểu để áp dụng

        public DateTime ExpirationDate { get; set; } // Hạn sử dụng
        public bool IsActive { get; set; } = true; // Trạng thái có thể sử dụng không

        public int? UsageLimit { get; set; } // Số lần sử dụng tối đa (null = không giới hạn)
        public int UsedCount { get; set; } = 0; // Số lần đã sử dụng
    }
}
