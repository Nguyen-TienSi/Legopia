using Legopia.Models.Entities;

namespace Legopia.Services
{
    public interface ICartService
    {
        void AddToCart(string userId, int productId, int quantity);
        Cart? GetCartByUserId(string userId);
    }
}
