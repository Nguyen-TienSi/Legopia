using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("post_categories")]
    public class PostCategory : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [Column("post_category_name")]
        public string PostCategoryName { get; set; } = string.Empty;
        // Many to one relationship
        public ICollection<Post> Posts { get; set; } = [];
    }
}
