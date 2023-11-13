using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Interfaces.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.DataLayer.Repositories.Concrete.Abstract
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<T> _table;
        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            this._dbContext = applicationDbContext;
            this._table = _dbContext.Set<T>();
        }
        public void Active(T entity)
        {
            _dbContext.SaveChanges();
        }
        public void Create(T entity)
        {
            _table.AddAsync(entity);
            _dbContext.SaveChanges();

        }
        public void Update(T entity)
        {
            _table.Update(entity);
            _dbContext.SaveChanges();

        }
        public void Delete(T entity)
        {
            _table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public T Get(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = _table;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query);
            }
            return query;
        }
        public T GetByDefault(Expression<Func<T, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<T> GetByDefaults(Expression<Func<T, bool>> exp) => _table.Where(exp).ToList();
        public T GetById(int id) => _table.Find(id);
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = _table;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            return query.FirstOrDefault();
        }
    }
}
