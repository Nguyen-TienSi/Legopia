using Legopia.Models.Entities;

namespace Legopia.Repositories
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Cart? GetCartByUserId(string userId);
    }
}
