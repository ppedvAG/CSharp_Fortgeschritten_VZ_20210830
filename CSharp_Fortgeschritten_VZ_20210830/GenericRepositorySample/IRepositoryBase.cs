using GenericRepositorySample.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample
{
    public interface IRepositoryBase<TEntity, TKey> :
        ICanRead<TEntity, TKey>,
        ICanAdd<TEntity>,
        ICanModify<TEntity>,
        ICanDelete<TEntity> where TEntity : class
    {
        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);
        void Commit();
    }
}
