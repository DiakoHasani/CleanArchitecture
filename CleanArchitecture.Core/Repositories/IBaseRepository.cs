using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> where);
        int SaveChange();
        Task<int> SaveChangesAsync();
        Task<T> GetByIdAsync(int id);
    }
}
