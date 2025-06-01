using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class TagServiceImpl : ITagService
    {
        private readonly ITagRepository _tagRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TagServiceImpl(ITagRepository tagRepository, IUnitOfWork unitOfWork)
        {
            _tagRepository = tagRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
