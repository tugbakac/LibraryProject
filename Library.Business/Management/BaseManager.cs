using FluentValidation;
using Library.Business.Services;
using Library.Business.Tools;
using Library.DAL.Abstract;
using LibraryProject.Entities.Abstract;
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
    public class BaseManager<TEntity, TDAL, TValidator> : IServiceBase<TEntity>
        where TEntity : class, IEntity, new()
        where TDAL : class, IEntityBase<TEntity>, new()
        where TValidator : IValidator, new()
    {
        TDAL _dal = new TDAL();
        ValidationTool verifyTool = new ValidationTool();
        TValidator verify = new TValidator();
        public TEntity Add(TEntity entity)
        {
            if (verifyTool.Verify(verify, entity))
            {
                return _dal.Add(entity);
            }
            else
            {
                return null;
            }
            //return _dal.Add(entity);
        }

        public TEntity AddOrUpdate(TEntity entity)
        {
            if (verifyTool.Verify(verify,entity))
            {
                return _dal.AddOrUpdate(entity);
            }
            else
            {
                return null;
            }
            //return _dal.AddOrUpdate(entity);
        }

        public BindingList<TEntity> ConnectionObject()
        {
            return _dal.ConnectionObject();
        }

        public DbContext CreateInstance(bool newContext = false)
        {
            return _dal.CreateInstance(newContext);
        }

        public virtual TEntity Delete(TEntity entity)
        {
            return _dal.Delete(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _dal.Delete(filter);
        }

        public TEntity GetList(Expression<Func<TEntity, bool>> filter)
        {
            return _dal.GetList(filter);
        }

        public List<TEntity> Listed(Expression<Func<TEntity, bool>> filter = null)
        {
            return _dal.Listed(filter);
        }

        public void Save()
        {
            _dal.Save();
        }

        public TEntity Update(TEntity entity)
        {
            if (verifyTool.Verify(verify, entity))
            {
                return _dal.Update(entity);
            }
            else
            {
                return null;
            }
            //return _dal.Update(entity);
        }
    }
}
