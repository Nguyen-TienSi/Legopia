using Legopia.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace Legopia.Areas.Admin.Models
{
    public class ProductCreateViewModel
    {
        public Product Product { get; set; } = new Product();
        public int? ThumbnailImageId { get; set; }
        public IFormFile? ThumbnailImageFile { get; set; }
        public List<IFormFile> ProductImageFiles { get; set; } = [];
    }
}
