using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("product_images")]
    public class ProductImage : BaseEntity
    {
        [Required]
        [Column("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
        // Many to many relationship
        public ICollection<ProductImageJoining> ProductImageJoinings { get; set; } = [];
    }
}
