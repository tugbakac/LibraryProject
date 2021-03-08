using FluentValidation;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Validations
{
    public class ClassOfMemberValidator:AbstractValidator<Lending>
    {
        public ClassOfMemberValidator()
        {

        }
    }
}
