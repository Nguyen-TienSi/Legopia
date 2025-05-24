using Legopia.Models.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("reviews")]
    public class ProductReview : BaseEntity
    {
        [Range(1, 5)]
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        // Many to one relationship
        [ForeignKey(nameof(Product))]
        [Column("product_id")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        [ForeignKey(nameof(UserDetails))]
        [Column("user_details_id")]
        public string? UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
    }
}
