using EFRepositorySample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer.Context;
using TheDataLayer.Entities;

namespace TheDataLayer.Repositories
{
    public class ContinentRepository : RepositoryBase<Continent, Guid>
    {
        public ContinentRepository()
            : base(DbContextFactory.GeoDBContextInstance)
        {
        }

        public override void Commit()
        {
            base.Commit();
        }

        public override int Count()
        {
            return base.Count();
        }

        public override int Count(Expression<Func<Continent, bool>> predicate)
        {
            return base.Count(predicate);
        }

        public override void Delete(Expression<Func<Continent, bool>> predicate)
        {
            base.Delete(predicate);
        }

        public override void Delete(Continent entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IList<Continent> GetAll()
        {
            return base.GetAll();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Insert(Continent entity)
        {
            base.Insert(entity);
        }

        public override Continent Single(Expression<Func<Continent, bool>> predicate)
        {
            return base.Single(predicate);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(Continent orginalEntity, Continent modifiedEntity)
        {
            base.Update(orginalEntity, modifiedEntity);
        }

        public override IQueryable<Continent> Where(Expression<Func<Continent, bool>> predicate)
        {
            return base.Where(predicate);
        }
    }
}
