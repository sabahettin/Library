using FluentValidation;
using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Validation.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.categoryName).NotEmpty().WithMessage("Kategori adı boş olamaz");
            RuleFor(x => x.categoryName).MinimumLength(3).WithMessage("Bölüm adı en az 3 karakter olmalıdır");
            RuleFor(x => x.categoryName).MinimumLength(25).WithMessage("Bölüm adı en fazla 25 karakter olmalıdır");
        }
    }
}
