using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> GetQueryable();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);
        void Remove(T entity);
    }
}
