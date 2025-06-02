using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("product_images")]
    public class ProductImage : BaseEntity
    {
        [Required]
        [Column("image_file_name")]
        public string ImageFileName { get; set; } = string.Empty;
        [Required]
        [Column("image_data")]
        public byte[] ImageData { get; set; } = [];
        // One to many relationship
        public ICollection<Product> Products { get; set; } = [];
        // Many to many relationship
        public ICollection<ProductImageJoining> ProductImageJoinings { get; set; } = [];
    }
}
