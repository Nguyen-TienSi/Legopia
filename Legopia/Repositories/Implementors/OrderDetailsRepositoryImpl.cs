using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class OrderDetailsRepositoryImpl : GenericRepositoryImpl<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
