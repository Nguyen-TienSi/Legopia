using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class OrderItemRepositoryImpl : GenericRepositoryImpl<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
