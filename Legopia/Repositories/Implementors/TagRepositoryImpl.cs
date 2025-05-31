using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class TagRepositoryImpl : GenericRepositoryImpl<Tag>, ITagRepository
    {
        public TagRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
