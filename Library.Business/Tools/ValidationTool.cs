using FluentValidation;
using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Business.Tools
{
    public class ValidationTool
    {
        public bool Verify(IValidator validator, IEntity entity)
        {
            bool result = true;

            var verifyControl = validator.Validate(entity);
            if (!verifyControl.IsValid)
            {
                string message = null;
                foreach (var error in verifyControl.Errors)
                {
                    message += error.ErrorMessage + System.Environment.NewLine;
                }
                MessageBox.Show(message);
                result = false;
            }

            return result;
        }
    }
}
