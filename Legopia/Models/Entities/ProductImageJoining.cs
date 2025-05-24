using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("product_image_joinings")]
    public class ProductImageJoining
    {
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public int? ProductImageId { get; set; }
        public ProductImage? ProductImage { get; set; }
    }
}
