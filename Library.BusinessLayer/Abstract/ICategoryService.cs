using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void TCreate(Category entity);
        void TUpdate(Category entity);
        void TDelete(Category entity);
        void TActive(Category entity);
        Category TGetById(int id);
        Category TGetByDefault(Expression<Func<Category, bool>> exp);
        List<Category> TGetByDefaults(Expression<Func<Category, bool>> exp);
        IQueryable<Category> TGetAll(Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = null);
        Category TGet(int id);
        Category TGetFirstOrDefault(Expression<Func<Category, bool>> filter = null, string includeProperties = null);
    }
}
