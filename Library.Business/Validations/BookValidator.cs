using FluentValidation;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Validations
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.BookCode).NotEmpty().WithMessage("Kitap Kodu alanı boş geçilemez");
            RuleFor(b => b.BookName).NotEmpty().WithMessage("Kitap Adı alanı boş geçilemez");
        }
    }
}
