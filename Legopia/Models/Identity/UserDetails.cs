using Microsoft.AspNetCore.Identity;
using Legopia.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Identity
{
    [Table("user_details")]
    public class UserDetails : IdentityUser
    {
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;
        // One to one relationship
        public Address? Address { get; set; }
        public Cart? Cart { get; set; }
        // One to many relationship
        public ICollection<OrderDetails> OrderDetails { get; set; } = [];
        public ICollection<Post> Posts { get; set; } = [];
        public ICollection<ProductReview> ProductReviews { get; set; } = [];
    }
}
