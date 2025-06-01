using Legopia.Models.Entities;
using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class PostCategoryServiceImpl : IPostCategoryService
    {
        private readonly IPostCategoryRepository _postCategoryRepository; 
        private readonly IUnitOfWork _unitOfWork;

        public PostCategoryServiceImpl(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            _postCategoryRepository = postCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PostCategory>> GetAllAsync()
        {
            return await _postCategoryRepository.FindAllAsync();
        }
    }
}
