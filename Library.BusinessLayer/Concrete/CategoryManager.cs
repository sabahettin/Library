using Library.BusinessLayer.Abstract;
using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Library.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<Category> _table;
        public CategoryManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this._table = _dbContext.Set<Category>();
        }
        public void TActive(Category entity)
        {
            _dbContext.SaveChanges();
        }
        public void TCreate(Category entity)
        {
            _table.AddAsync(entity);
            _dbContext.SaveChanges();
        }
        public void TUpdate(Category entity)
        {
            _table.Update(entity);
            _dbContext.SaveChanges();

        }
        public void TDelete(Category entity)
        {
            _table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public Category TGet(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<Category> TGetAll(Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = null)
        {
            IQueryable<Category> query = _table;
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
        public Category TGetByDefault(Expression<Func<Category, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<Category> TGetByDefaults(Expression<Func<Category, bool>> exp) => _table.Where(exp).ToList();
        public Category TGetById(int id) => _table.Find(id);
        public Category TGetFirstOrDefault(Expression<Func<Category, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<Category> query = _table;
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
