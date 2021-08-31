using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface IAddCommand<T> 
    {
        public void Add(T item);
        public void Add(T[] items);
    }
}
