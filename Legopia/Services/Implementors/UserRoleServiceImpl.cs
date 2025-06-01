using Legopia.Models.Identity;
using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class UserRoleServiceImpl : IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserRoleServiceImpl(IUserRoleRepository userRoleRepository, IUnitOfWork unitOfWork)
        {
            _userRoleRepository = userRoleRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<UserRole>> GetAllAsync()
        {
            return await _userRoleRepository.FindAllAsync();
        }
    }
}
