using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
    public interface IServiceBase<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> Listed(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetList(Expression<Func<TEntity, bool>> filter);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity AddOrUpdate(TEntity entity);
        TEntity Delete(TEntity entity);
        void Save();
        BindingList<TEntity> ConnectionObject();
        DbContext CreateInstance(bool newContext = false);
        void Delete(Expression<Func<TEntity, bool>> filter);
    }
}
