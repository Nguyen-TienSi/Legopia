using Legopia.Models.Entities;
using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class ProductServiceImpl : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductServiceImpl(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.FindAll();
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
            _unitOfWork.SaveChanges();
        }
    }
}
