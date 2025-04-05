using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Legopia.Models.Entities
{
    public class PostCategory
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // Tên danh mục

        public ICollection<Post> Posts { get; set; } = new List<Post>(); // Các bài viết thuộc danh mục này
    }
}
