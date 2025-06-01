using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class ProductImageServiceImpl : IProductImageService
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductImageServiceImpl(IProductImageRepository productImageRepository, IUnitOfWork unitOfWork)
        {
            _productImageRepository = productImageRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
