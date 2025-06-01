using Legopia.Repositories;

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
    }
}
