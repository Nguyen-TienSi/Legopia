using Microsoft.AspNetCore.Identity;

namespace Legopia.Models.Identity
{
    public class AppRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}
