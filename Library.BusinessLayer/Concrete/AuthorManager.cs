using Library.BusinessLayer.Abstract;
using Library.BusinessLayer.Validation.FluentValidation;
using Library.CoreLayer.Validation;
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

namespace Library.BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<Author> _table;
        public AuthorManager(ApplicationDbContext dbContext, IAuthorRepository authorRepository)
        {
            _dbContext = dbContext;
            this._table = _dbContext.Set<Author>();
            _authorRepository = authorRepository;
        }
        public void TActive(Author entity)
        {
            _dbContext.SaveChanges();
        }
        public bool TCreate(Author entity)
        {
            bool validation = ValidationTool.Validate(new AuthorValidator(), entity);
            if (validation)
            {
                _table.AddAsync(entity);
                _dbContext.SaveChanges();
                MessageBox.Show("Yazar Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public bool TUpdate(Author entity)
        {
            bool validation = ValidationTool.Validate(new AuthorValidator(), entity);
            if (validation)
            {
                _table.Update(entity);
                _dbContext.SaveChanges();
                MessageBox.Show("Yazar Güncelleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;

        }
        public void TDelete(Author entity)
        {
            var result = _authorRepository.CheckAuthortUses(entity.authorId);
            if (!result)
            {
                MessageBox.Show("Bu yazara ait olan kitap bulunduğundan yazar silinemiyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _table.Remove(entity);
            _dbContext.SaveChanges();
        }
        public Author TGet(int id)
        {
            return _table.Find(id);
        }
        public IQueryable<Author> TGetAll(Expression<Func<Author, bool>> filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>> orderBy = null, string includeProperties = null)
        {
            IQueryable<Author> query = _table;
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
        public Author TGetByDefault(Expression<Func<Author, bool>> exp) => _table.Where(exp).FirstOrDefault();
        public List<Author> TGetByDefaults(Expression<Func<Author, bool>> exp) => _table.Where(exp).ToList();
        public Author TGetById(int id) => _table.Find(id);
        public Author TGetFirstOrDefault(Expression<Func<Author, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<Author> query = _table;
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
