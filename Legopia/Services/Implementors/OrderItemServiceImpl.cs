using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class OrderItemServiceImpl : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemServiceImpl(IOrderItemRepository orderItemRepository, IUnitOfWork unitOfWork)
        {
            _orderItemRepository = orderItemRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
