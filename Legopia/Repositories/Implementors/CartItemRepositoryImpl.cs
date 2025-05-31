using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class CartItemRepositoryImpl : GenericRepositoryImpl<CartItem>, ICartItemRepository
    {
        public CartItemRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
