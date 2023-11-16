using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Abstract
{
    public interface IMemberService
    {
        void TCreate(Member entity);
        void TUpdate(Member entity);
        void TDelete(Member entity);
        void TActive(Member entity);
        Member TGetById(int id);
        Member TGetByDefault(Expression<Func<Member, bool>> exp);
        List<Member> TGetByDefaults(Expression<Func<Member, bool>> exp);
        IQueryable<Member> TGetAll(Expression<Func<Member, bool>> filter = null, Func<IQueryable<Member>, IOrderedQueryable<Member>> orderBy = null, string includeProperties = null);
        Member TGet(int id);
        Member TGetFirstOrDefault(Expression<Func<Member, bool>> filter = null, string includeProperties = null);
    }
}
