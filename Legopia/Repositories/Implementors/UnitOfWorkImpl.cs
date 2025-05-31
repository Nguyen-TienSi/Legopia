using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class UnitOfWorkImpl : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWorkImpl(DbContext context)
        {
            _context = context;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
