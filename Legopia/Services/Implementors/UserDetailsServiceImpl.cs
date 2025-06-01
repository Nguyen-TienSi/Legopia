using Legopia.Models.Identity;
using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class UserDetailsServiceImpl : IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetailsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserDetailsServiceImpl(IUserDetailsRepository userDetailsRepository, IUnitOfWork unitOfWork)
        {
            _userDetailsRepository = userDetailsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<UserDetails>> GetAllAsync()
        {
            return await _userDetailsRepository.FindAllAsync();
        }
    }
}
