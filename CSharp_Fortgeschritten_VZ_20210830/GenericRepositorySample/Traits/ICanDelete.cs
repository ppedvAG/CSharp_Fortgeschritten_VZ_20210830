using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface ICanDelete<TEntity> where TEntity : class
    {
        void Delete(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);

    }
}
