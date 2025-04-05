using Legopia.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace Legopia.Models.Entities
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; } // Tiêu đề bài viết

        [Required]
        public string Content { get; set; } // Nội dung bài viết

        public string ImageUrl { get; set; } // Ảnh đại diện bài viết

        public bool IsPublished { get; set; } = false; // Trạng thái xuất bản

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Ngày tạo
        public DateTime? UpdatedAt { get; set; } // Ngày cập nhật (có thể null)

        public string AuthorId { get; set; }
        public AppUser Author { get; set; } // Người tạo bài viết

        public int? CategoryId { get; set; }
        public PostCategory Category { get; set; } // Danh mục bài viết

        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>(); // Thẻ bài viết
    }
}
