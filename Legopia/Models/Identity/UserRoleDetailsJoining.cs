using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Identity
{
    [Table("user_role_details_joining", Schema = "identity")]
    public class UserRoleDetailsJoining
    {
        public string? UserDetailsId { get; set; }
        public UserDetails? UserDetails { get; set; }
        public string? UserRoleId { get; set; }
        public UserRole? UserRole { get; set; }
    }
}
