using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext _dataContext;
        DbSet<T> db;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            db = dataContext.Set<T>();
        }

        public void Add(T entity)
        {
            db.Add(entity);
        }

        public void Delete(T entity)
        {
            db.Remove(entity);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> where)
        {
            if (where != null)
                return db.Where(where);
            return db;
        }

        public T GetById(int id)
        {
            return db.Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await db.FindAsync(id);
        }

        public int SaveChange()
        {
            return _dataContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
