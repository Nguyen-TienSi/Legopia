using Legopia.Repositories;

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
    }
}
