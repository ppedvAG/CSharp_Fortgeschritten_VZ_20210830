using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface IUpdateCommand<T>
    {
        public void Update(int Id, T item);
    }
}
