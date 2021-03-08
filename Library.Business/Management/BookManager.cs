using Library.Business.Services;
using Library.Business.Validations;
using Library.DAL.Abstract;
using Library.DAL.EF;
using LibraryProject.Entities.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Management
{
    class BookManager : BaseManager<Book, BookDAL,BookValidator>, IBookService
    {
        //DependencyInjection
        //private IBookDAL _bookDAL;
        //public BookManager(IBookDAL bookDAL)
        //{
        //    _bookDAL = bookDAL;
        //}
        public Book GetById(int Id)
        {
            return this.GetList(b => b.ID == Id);
        }

        public override Book Delete(Book entity)
        {
            return base.Delete(entity);
            ILendingService lendingService = new LendingManager();
            lendingService.Delete(b => b.BookID == entity.ID);
        }
    }
}
