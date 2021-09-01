using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface ICanRead<TEntity, TKey> where TEntity : class
    {
        // SINGLE
        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        // WHERE
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        // ALL
        IList<TEntity> GetAll();
    }
}
