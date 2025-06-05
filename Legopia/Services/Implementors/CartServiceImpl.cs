using Legopia.Models.Entities;
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

        public Cart? GetCartByUserId(string userId)
        {
            return _cartRepository.GetCartByUserId(userId);
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = _cartRepository
                .FindAll()
                .FirstOrDefault(c => c.UserDetailsId == userId);

            if (cart == null)
            {
                cart = new Cart { UserDetailsId = userId };
                _cartRepository.Add(cart);
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cart.CartItems.Add(new CartItem
                {
                    CartId = cart.UserDetailsId,
                    ProductId = productId,
                    Quantity = quantity
                });
            }

            _unitOfWork.SaveChanges();
        }
    }
}
