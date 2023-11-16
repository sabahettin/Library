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
    public class PublishingHouseManager : IPublishingHouseService
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<PublishingHouse> _table;
        public PublishingHouseManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this._table = _dbContext.Set<PublishingHouse>();
        }
        public void TActive(PublishingHouse entity)
        {
            _dbContext.SaveChanges();
        }
        public void TCreate(PublishingHouse entity)
        {
            _table.AddAsync(entity);
            _dbContext.SaveChanges();
        }
        public void TUpdate(PublishingHouse entity)
        {
            _table.Update(entity);
            _dbContext.SaveChanges();

        }
        public void TDelete(PublishingHouse entity)
        {
            _table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public PublishingHouse TGet(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<PublishingHouse> TGetAll(Expression<Func<PublishingHouse, bool>> filter = null, Func<IQueryable<PublishingHouse>, IOrderedQueryable<PublishingHouse>> orderBy = null, string includeProperties = null)
        {
            IQueryable<PublishingHouse> query = _table;
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
        public PublishingHouse TGetByDefault(Expression<Func<PublishingHouse, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<PublishingHouse> TGetByDefaults(Expression<Func<PublishingHouse, bool>> exp) => _table.Where(exp).ToList();
        public PublishingHouse TGetById(int id) => _table.Find(id);
        public PublishingHouse TGetFirstOrDefault(Expression<Func<PublishingHouse, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<PublishingHouse> query = _table;
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
