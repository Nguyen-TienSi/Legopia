using Legopia.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Identity
{
    [Table("addresses")]
    public class Address : BaseEntity
    {
        [ForeignKey(nameof(UserDetails))]
        [Column("user_details_id")]
        public string? UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
        public OrderDetails? OrderDetails { get; set; }
    }
}
