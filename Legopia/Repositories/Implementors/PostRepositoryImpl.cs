using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class PostRepositoryImpl : GenericRepositoryImpl<Post>, IPostRepository
    {
        public PostRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
