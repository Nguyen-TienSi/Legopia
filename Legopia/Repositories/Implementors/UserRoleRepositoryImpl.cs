using Legopia.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class UserRoleRepositoryImpl : GenericRepositoryImpl<UserRole>, IUserRoleRepository
    {
        public UserRoleRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
