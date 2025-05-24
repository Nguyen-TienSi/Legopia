using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("post_tags")]
    [PrimaryKey(nameof(PostId), nameof(TagId))]
    public class PostTagJoining
    {
        // Many to many relationship
        [ForeignKey(nameof(Post))]
        [Column("post_id")]
        public int? PostId { get; set; }
        public Post? Post { get; set; }
        [ForeignKey(nameof(Tag))]
        [Column("tag_id")]
        public int? TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
