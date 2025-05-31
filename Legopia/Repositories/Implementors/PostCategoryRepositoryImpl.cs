using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class PostCategoryRepositoryImpl : GenericRepositoryImpl<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
