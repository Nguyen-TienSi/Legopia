using Legopia.Areas.Admin.Models;
using Legopia.Models.Entities;
using Legopia.Repositories;
using Legopia.Repositories.Implementors;

namespace Legopia.Services.Implementors
{
    public class ProductServiceImpl : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductImageRepository _productImageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductServiceImpl(
            IProductRepository productRepository,
            IProductImageRepository productImageRepository,
            IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _productImageRepository = productImageRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.FindAll();
        }

        public void Add(ProductCreateViewModel viewModel)
        {
            var product = viewModel.Product;

            // Handle uploaded product images
            if (viewModel.ProductImageFiles != null)
            {
                foreach (var file in viewModel.ProductImageFiles)
                {
                    if (file.Length > 0)
                    {
                        using var ms = new MemoryStream();
                        file.CopyTo(ms);
                        var image = new ProductImage
                        {
                            ImageFileName = file.FileName,
                            ImageData = ms.ToArray()
                        };
                        _productImageRepository.Add(image);

                        product.ProductImageJoining.Add(new ProductImageJoining
                        {
                            Product = product,
                            ProductImage = image
                        });
                    }
                }
            }

            // Handle thumbnail image after product is saved
            if (viewModel.ThumbnailImageFile != null && viewModel.ThumbnailImageFile.Length > 0)
            {
                using var ms = new MemoryStream();
                viewModel.ThumbnailImageFile.CopyTo(ms);
                var thumbImage = new ProductImage
                {
                    ImageFileName = viewModel.ThumbnailImageFile.FileName,
                    ImageData = ms.ToArray()
                };
                _productImageRepository.Add(thumbImage);

                product.ThumbnailImage = thumbImage;

                product.ProductImageJoining.Add(new ProductImageJoining
                {
                    Product = product,
                    ProductImage = thumbImage,
                });
            }

            _productRepository.Add(product);
            _unitOfWork.SaveChanges();
        }
    }
}
