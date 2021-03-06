using ApiWorkshop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                try
                {
                    if (filter == null)
                    {
                        return context.Set<TEntity>().ToList();
                    }
                    else
                    {
                        return context.Set<TEntity>().Where(filter).ToList();
                    }
                }
                catch (Exception ex)
                {
                    //todo: log
                    return null;
                }
            }
        }

        public int Count(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                try
                {
                    return context.Set<TEntity>().Where(filter).Count();
                }
                catch (Exception)
                {
                    //todo: log
                    return 0;
                }
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                try
                {
                    return context.Set<TEntity>().FirstOrDefault(filter);
                }
                catch (Exception ex)
                {
                    //todo: log
                    return null;
                }
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                try
                {
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    //todo: log
                }
                return entity;
            }
        }

        public TEntity Modify(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                try
                {
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    //todo: log
                    throw;
                }
                return entity;
            }
        }

        public bool Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                try
                {
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    //todo: log
                    return false;
                }
            }
        }
    }
}
