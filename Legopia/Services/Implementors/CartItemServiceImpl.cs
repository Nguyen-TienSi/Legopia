using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class CartItemServiceImpl : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CartItemServiceImpl(ICartItemRepository cartItemRepository, IUnitOfWork unitOfWork)
        {
            _cartItemRepository = cartItemRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
