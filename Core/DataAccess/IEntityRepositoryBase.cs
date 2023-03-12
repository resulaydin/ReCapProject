using Core.Entities;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public abstract class IEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() // a: 
        where TContext :  DbContext,new()// b:  
        
    {
        public void Add(TEntity entity)
        {
            using (var _context = new TContext())
            {
                _context.Set<TEntity>().Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var _context = new TContext())
            {
                _context.Set<TEntity>().Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity,bool>> filter)
        {
            using (var _context = new TContext())
            {
                return _context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        // Buraya neden bool yazıldı.
        public List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null)
        {
            using (var _context = new TContext())
            {
                return filter == null 
                    ? _context.Set<TEntity>().ToList()
                    : _context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var _context = new TContext())
            {
                _context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
