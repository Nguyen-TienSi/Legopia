using Legopia.Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("carts")]
    public class Cart
    {
        // One to one relationship 
        [Key, ForeignKey(nameof(UserDetails))]
        [Column("user_details_id")]
        public string? UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
        // One to many relationship
        public ICollection<CartItem> CartItems { get; set; } = [];
    }
}
