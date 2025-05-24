using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("tags")]
    public class Tag : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        [Column("tag_name")]
        public string TagName { get; set; } = string.Empty;
        // Many to many relationship
        public ICollection<PostTagJoining> PostTagJoinings { get; set; } = [];
    }
}
