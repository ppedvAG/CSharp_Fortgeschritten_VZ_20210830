using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface ICanAdd<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
    }
}
