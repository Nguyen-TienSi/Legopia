using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class CartRepositoryImpl : GenericRepositoryImpl<Cart>, ICartRepository
    {
        public CartRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
