using Library.DAL.Abstract;
using Library.DAL.Context;
using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.EF
{
    public class EFBaseDAL<TEntity, TContext> : IEntityBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public DbContext CreateInstance(bool newContext = false)
        {
            return newContext == true ? _context = new TContext() : _context;
        }

        private TContext _context;
        //LibraryContext _context = new LibraryContext();
        public TEntity Add(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Added;
            return entity;
        }

        public TEntity AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate();
            return entity;
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filter));
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Deleted;
            return entity;
        }

        public TEntity GetList(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }

        List<TEntity> IEntityBase<TEntity>.Listed(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public BindingList<TEntity> ConnectionObject()
        {
            _context.Set<TEntity>().Load();
            return _context.Set<TEntity>().Local.ToBindingList();
        }
    }
}
