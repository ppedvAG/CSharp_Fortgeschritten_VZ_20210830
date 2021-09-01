using GenericRepositorySample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFRepositorySample
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : class
    {
        private DbContext _dbContext = null;
        private DbSet<TEntity> _dbSet = null;

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            DbSet = _dbContext.Set<TEntity>();
        }

        public DbSet<TEntity> DbSet { get => _dbSet; set => _dbSet = value; }

        public virtual void Commit()
        {
            _dbContext.SaveChanges();
        }

        public virtual int Count()
        {
            return DbSet.Count();
        }

        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Count(predicate);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> predicate)
        {

        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public virtual IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }



        public virtual TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Single(predicate);
        }

        public virtual void Update(TEntity orginalEntity, TEntity modifiedEntity)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }
    }
}
