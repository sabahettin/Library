using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Concrete.Abstract;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer.Repositories.Concrete.EntityTypeRepository
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AuthorRepository(ApplicationDbContext applicationDbContext, ApplicationDbContext dbContext) : base(applicationDbContext)
        {
            _dbContext = dbContext;
        }

        public bool CheckAuthortUses(int authorId)
        {
            var result = _dbContext.Books.Where(x => x.authorId == authorId);
            return (result.Count() > 0 ? false : true);
        }
    }
}
