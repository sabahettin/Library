using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Abstract
{
    public interface IPublishingHouseService
    {
        void TCreate(PublishingHouse entity);
        void TUpdate(PublishingHouse entity);
        void TDelete(PublishingHouse entity);
        void TActive(PublishingHouse entity);
        PublishingHouse TGetById(int id);
        PublishingHouse TGetByDefault(Expression<Func<PublishingHouse, bool>> exp);
        List<PublishingHouse> TGetByDefaults(Expression<Func<PublishingHouse, bool>> exp);
        IQueryable<PublishingHouse> TGetAll(Expression<Func<PublishingHouse, bool>> filter = null, Func<IQueryable<PublishingHouse>, IOrderedQueryable<PublishingHouse>> orderBy = null, string includeProperties = null);
        PublishingHouse TGet(int id);
        PublishingHouse TGetFirstOrDefault(Expression<Func<PublishingHouse, bool>> filter = null, string includeProperties = null);
    }
}
