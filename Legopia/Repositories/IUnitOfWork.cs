using System;
using System.Threading.Tasks;

namespace Legopia.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
