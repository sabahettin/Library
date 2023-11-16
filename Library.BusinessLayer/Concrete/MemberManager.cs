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
    public class MemberManager : IMemberService
    {
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<Member> _table;
        public MemberManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this._table = _dbContext.Set<Member>();
        }
        public void TActive(Member entity)
        {
            _dbContext.SaveChanges();
        }
        public void TCreate(Member entity)
        {
            _table.AddAsync(entity);
            _dbContext.SaveChanges();
        }
        public void TUpdate(Member entity)
        {
            _table.Update(entity);
            _dbContext.SaveChanges();

        }
        public void TDelete(Member entity)
        {
            _table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public Member TGet(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<Member> TGetAll(Expression<Func<Member, bool>> filter = null, Func<IQueryable<Member>, IOrderedQueryable<Member>> orderBy = null, string includeProperties = null)
        {
            IQueryable<Member> query = _table;
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
        public Member TGetByDefault(Expression<Func<Member, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<Member> TGetByDefaults(Expression<Func<Member, bool>> exp) => _table.Where(exp).ToList();
        public Member TGetById(int id) => _table.Find(id);
        public Member TGetFirstOrDefault(Expression<Func<Member, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<Member> query = _table;
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
