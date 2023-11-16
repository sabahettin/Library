using Library.BusinessLayer.Abstract;
using Library.DataLayer.Context;
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
    public class EmailManager : IEmailService
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<Email> _table;
        public EmailManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this._table = _dbContext.Set<Email>();
        }
        public void TActive(Email entity)
        {
            _dbContext.SaveChanges();
        }
        public void TCreate(Email entity)
        {
            _table.AddAsync(entity);
            _dbContext.SaveChanges();
        }
        public void TUpdate(Email entity)
        {
            _table.Update(entity);
            _dbContext.SaveChanges();

        }
        public void TDelete(Email entity)
        {
            _table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public Email TGet(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<Email> TGetAll(Expression<Func<Email, bool>> filter = null, Func<IQueryable<Email>, IOrderedQueryable<Email>> orderBy = null, string includeProperties = null)
        {
            IQueryable<Email> query = _table;
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
        public Email TGetByDefault(Expression<Func<Email, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<Email> TGetByDefaults(Expression<Func<Email, bool>> exp) => _table.Where(exp).ToList();
        public Email TGetById(int id) => _table.Find(id);
        public Email TGetFirstOrDefault(Expression<Func<Email, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<Email> query = _table;
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
