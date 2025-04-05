using System.ComponentModel.DataAnnotations;

namespace Legopia.Models.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; } // Đường dẫn ảnh

        public int ProductId { get; set; }
        public Product Product { get; set; } // Liên kết với sản phẩm
    }
}
