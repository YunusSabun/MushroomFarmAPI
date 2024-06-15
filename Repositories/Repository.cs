using Microsoft.EntityFrameworkCore;
using MushroomFarmAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MushroomFarmContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(MushroomFarmContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity ?? throw new KeyNotFoundException($"Entity with id {id} not found.");
        }

        public async Task<T> Add(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
