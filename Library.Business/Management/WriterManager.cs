using Library.Business.Services;
using Library.Business.Validations;
using Library.DAL.EF;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Management
{
    public class WriterManager : BaseManager<Writer, WriterDAL,WriterValidator>, IWriterService
    {
    }
}
