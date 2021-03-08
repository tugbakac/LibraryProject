using FluentValidation;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Validations
{
    public class BarcodeValidator : AbstractValidator<Barcode>
    {
        public BarcodeValidator()
        {
            RuleFor(b => b.BookBarcode).NotEmpty().WithMessage("Barkod alanı boş geçilemez.");
        }
    }
}
