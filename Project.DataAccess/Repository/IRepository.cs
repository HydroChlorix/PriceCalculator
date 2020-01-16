using Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.DataAccess.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task AddAsync(T item);

        void Update(T item);
    }
}
