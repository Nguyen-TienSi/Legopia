using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("product_image_joinings")]
    [PrimaryKey(nameof(ProductId), nameof(ProductImageId))]
    public class ProductImageJoining
    {
        [ForeignKey(nameof(Product))]
        [Column("product_id")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        [ForeignKey(nameof(ProductImage))]
        [Column("product_image_id")]
        public int? ProductImageId { get; set; }
        public ProductImage? ProductImage { get; set; }
    }
}
