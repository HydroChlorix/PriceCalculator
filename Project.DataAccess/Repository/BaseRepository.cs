using Microsoft.EntityFrameworkCore;
using Project.DataAccess.Context;
using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext context;

        protected BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await context.Set<T>().SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task AddAsync(T item)
        {
            await context.Set<T>().AddAsync(item);
        }
        public void Update(T item)
        {
            context.Set<T>().Update(item);
        }
        public async Task<bool> IsExist(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).AnyAsync();
        }
    }
}
