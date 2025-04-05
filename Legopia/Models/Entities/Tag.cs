using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Legopia.Models.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } // Tên thẻ (VD: "Lego", "Review", "Sản phẩm mới")

        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>(); // Các bài viết có thẻ này
    }
}
