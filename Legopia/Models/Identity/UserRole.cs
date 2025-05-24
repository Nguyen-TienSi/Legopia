using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Identity
{
    [Table("user_roles")]
    public class UserRole : IdentityRole
    {
        [Column("description")]
        public string? Description { get; set; }
    }
}
