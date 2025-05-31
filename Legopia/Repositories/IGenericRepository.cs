using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Legopia.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        // Async methods
        Task<TEntity?> FindByIdAsync(object id);
        Task<IEnumerable<TEntity>> FindAllAsync();
        Task AddAsync(TEntity entity);

        // Sync methods
        TEntity? FindById(object id);
        IEnumerable<TEntity> FindAll();
        void Add(TEntity entity);

        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>>? predicate = null);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
