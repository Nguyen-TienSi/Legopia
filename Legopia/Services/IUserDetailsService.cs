using Legopia.Models.Identity;

namespace Legopia.Services
{
    public interface IUserDetailsService
    {
        Task<IEnumerable<UserDetails>> GetAllAsync();
    }
}
