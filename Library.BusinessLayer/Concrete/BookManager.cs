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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<Book> _table;
        public BookManager( ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this._table = _dbContext.Set<Book>();
        }
        public void TActive(Book entity)
        {
            _dbContext.SaveChanges();
        }
        public void TCreate(Book entity)
        {
            _table.AddAsync(entity);
            _dbContext.SaveChanges();
        }
        public void TUpdate(Book entity)
        {
            _table.Update(entity);
            _dbContext.SaveChanges();

        }
        public void TDelete(Book entity)
        {
            entity.status = false;
            //_table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public Book TGet(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<Book> TGetAll(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, string includeProperties = null)
        {
            IQueryable<Book> query = _table;
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
        public Book TGetByDefault(Expression<Func<Book, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<Book> TGetByDefaults(Expression<Func<Book, bool>> exp) => _table.Where(exp).ToList();
        public Book TGetById(int id) => _table.Find(id);
        public Book TGetFirstOrDefault(Expression<Func<Book, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<Book> query = _table;
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
