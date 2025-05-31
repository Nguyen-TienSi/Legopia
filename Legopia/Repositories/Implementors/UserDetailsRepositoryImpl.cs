using Legopia.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class UserDetailsRepositoryImpl : GenericRepositoryImpl<UserDetails>, IUserDetailsRepository
    {
        public UserDetailsRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
