using Legopia.Models.Entities;

namespace Legopia.Services
{
    public interface IPostCategoryService
    {
        Task<IEnumerable<PostCategory>> GetAllAsync();
    }
}
