using Library.DAL.Abstract;
using Library.DAL.Context;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.EF
{
    public class WriterDAL : EFBaseDAL<Writer, LibraryContext>, IWriterDAL
    {
    }
}
