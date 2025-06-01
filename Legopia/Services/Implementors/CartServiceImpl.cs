using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class CartServiceImpl : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CartServiceImpl(ICartRepository cartRepository, IUnitOfWork unitOfWork)
        {
            _cartRepository = cartRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
