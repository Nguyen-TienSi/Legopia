using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("product_categories")]
    public class ProductCategory : BaseEntity
    {
        [Required]
        [Column("category_name")]
        public string CategoryName { get; set; } = string.Empty;
        // One to many relationship
        public ICollection<Product> Products { get; set; } = [];
    }
}
