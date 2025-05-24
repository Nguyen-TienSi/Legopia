using Legopia.Models.Enums;
using Legopia.Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("posts")]
    public class Post : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Column("content")]
        public string Content { get; set; } = string.Empty;
        [Column("post_status")]
        public PostStatus PostStatus { get; set; }
        // Many to one relationship 
        [ForeignKey(nameof(Author))]
        [Column("author_id")]
        public string? AuthorId { get; set; }
        public UserDetails? Author { get; set; }
        [ForeignKey(nameof(Category))]
        [Column("category_id")]
        public int? CategoryId { get; set; }
        public PostCategory? Category { get; set; }
        // Many to many relationship
        public ICollection<PostTagJoining> PostTagJoinings { get; set; } = [];
    }
}
