using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Abstract
{
    public interface IEmailService
    {
        void TCreate(Email entity);
        void TUpdate(Email entity);
        void TDelete(Email entity);
        void TActive(Email entity);
        Email TGetById(int id);
        Email TGetByDefault(Expression<Func<Email, bool>> exp);
        List<Email> TGetByDefaults(Expression<Func<Email, bool>> exp);
        IQueryable<Email> TGetAll(Expression<Func<Email, bool>> filter = null, Func<IQueryable<Email>, IOrderedQueryable<Email>> orderBy = null, string includeProperties = null);
        Email TGet(int id);
        Email TGetFirstOrDefault(Expression<Func<Email, bool>> filter = null, string includeProperties = null);
    }
}
