using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class ProductReviewServiceImpl : IProductReviewService
    {
        private readonly IProductReviewRepository _productReviewRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductReviewServiceImpl(IProductReviewRepository productReviewRepository, IUnitOfWork unitOfWork)
        {
            _productReviewRepository = productReviewRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
