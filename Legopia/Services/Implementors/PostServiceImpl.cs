using Legopia.Models.Entities;
using Legopia.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Legopia.Services.Implementors
{
    public class PostServiceImpl : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PostServiceImpl(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _postRepository.FindAllAsync();
        }
    }
}
