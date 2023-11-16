using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Abstract
{
    public interface IAuthorService
    {
        bool TCreate(Author entity);
        bool TUpdate(Author entity);
        void TDelete(Author entity);
        void TActive(Author entity);
        Author TGetById(int id);
        Author TGetByDefault(Expression<Func<Author, bool>> exp);
        List<Author> TGetByDefaults(Expression<Func<Author, bool>> exp);
        IQueryable<Author> TGetAll(Expression<Func<Author, bool>> filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>> orderBy = null, string includeProperties = null);
        Author TGet(int id);
        Author TGetFirstOrDefault(Expression<Func<Author, bool>> filter = null, string includeProperties = null);
    }
}
