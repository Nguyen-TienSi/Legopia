using Legopia.Models.Entities;
using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class ProductCategoryServiceImpl : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductCategoryServiceImpl(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ProductCategory>> GetAllAsync()
        {
            return await _productCategoryRepository.FindAllAsync();
        }
    }
}
