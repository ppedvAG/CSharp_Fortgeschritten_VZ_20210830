using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface ICanModify<TEntity> where TEntity : class
    {
        void Update(TEntity orginalEntity, TEntity modifiedEntity);
    }
}
