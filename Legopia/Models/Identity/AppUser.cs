using Microsoft.AspNetCore.Identity;
using Legopia.Models.Entities;

namespace Legopia.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
