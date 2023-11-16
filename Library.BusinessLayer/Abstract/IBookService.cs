using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Abstract
{
    public interface IBookService
    {
        void TCreate(Book entity);
        void TUpdate(Book entity);
        void TDelete(Book entity);
        void TActive(Book entity);
        Book TGetById(int id);
        Book TGetByDefault(Expression<Func<Book, bool>> exp);
        List<Book> TGetByDefaults(Expression<Func<Book, bool>> exp);
        IQueryable<Book> TGetAll(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, string includeProperties = null);
        Book TGet(int id);
        Book TGetFirstOrDefault(Expression<Func<Book, bool>> filter = null, string includeProperties = null);
    }
}
