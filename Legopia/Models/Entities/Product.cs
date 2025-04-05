using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; } // Giá sau khi giảm (nếu có)
        public float? DiscountPercentage { get; set; } // % giảm giá (nếu có)

        public string ThumbnailUrl { get; set; } // Ảnh đại diện

        public int Stock { get; set; } // Số lượng tồn kho

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>(); // Thư viện ảnh

        [NotMapped] // Không lưu vào DB, chỉ hiển thị trên giao diện
        public decimal FinalPrice
        {
            get
            {
                if (DiscountPercentage.HasValue && DiscountPercentage > 0)
                {
                    return Price - (Price * (decimal)DiscountPercentage.Value / 100);
                }
                return DiscountPrice ?? Price;
            }
        }
    }
}
