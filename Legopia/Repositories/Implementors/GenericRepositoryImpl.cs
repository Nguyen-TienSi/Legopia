using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Legopia.Repositories.Implementors
{
    public class GenericRepositoryImpl<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepositoryImpl(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public DbContext Context => _context;

        // Async methods
        public async Task<TEntity?> FindByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        // Sync methods
        public TEntity? FindById(object id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return [.. _dbSet];
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return predicate == null ? _dbSet : _dbSet.Where(predicate);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
