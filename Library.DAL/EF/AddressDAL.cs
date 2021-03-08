using Library.DAL.Abstract;
using Library.DAL.Context;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.EF
{
    public class AddressDAL : EFBaseDAL<Address,LibraryContext>, IAddressDAL
    {
        
    }
}
