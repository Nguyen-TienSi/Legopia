using Legopia.Models.Identity;

namespace Legopia.Services
{
    public interface IUserRoleService
    {
        Task<IEnumerable<UserRole>> GetAllAsync();
    }
}
