using FluentValidation;
using Library.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLayer.Validation.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.authorName).NotEmpty().WithMessage("Yazar adı boş olamaz");
            RuleFor(x => x.authorName).MinimumLength(3).WithMessage("Yazar adı en az 3 karakter olmalıdır");
            RuleFor(x => x.authorName).MinimumLength(25).WithMessage("Yazar adı en fazla 25 karakter olmalıdır");
        }
    }
}
