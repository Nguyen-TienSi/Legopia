using Legopia.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legopia.Services
{
    public interface IOrderDetailsService
    {
        Task<IEnumerable<OrderDetails>> GetAllAsync();
    }
}
