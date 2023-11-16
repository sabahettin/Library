using System.Linq.Expressions;

namespace Library.DataLayer.Repositories.Interfaces.Abstract
{
    public interface IBaseRepository<T> where T : class,new()
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Active(T entity);
        T GetById(int id);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetByDefaults(Expression<Func<T, bool>> exp);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        T Get(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);
    }
}
