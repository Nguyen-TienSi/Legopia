using Legopia.Models.Entities;
using Legopia.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legopia.Services.Implementors
{
    public class OrderDetailsServiceImpl : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailsServiceImpl(IOrderDetailsRepository orderDetailsRepository, IUnitOfWork unitOfWork)
        {
            _orderDetailsRepository = orderDetailsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<OrderDetails>> GetAllAsync()
        {
            return await _orderDetailsRepository.FindAllAsync();
        }
    }
}
