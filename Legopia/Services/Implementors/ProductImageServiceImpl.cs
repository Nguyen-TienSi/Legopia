using Legopia.Models.Entities;
using Legopia.Repositories;
using System.Collections.Generic;

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

        public IEnumerable<ProductImage> GetAll()
        {
            return _productImageRepository.FindAll();
        }

        public ProductImage? GetById(int id)
        {
            return _productImageRepository.FindById(id);
        }
    }
}
