using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface IDeleteCommand<T>
    {
        void Delete(T item);

        void Delete(int id);
    }
}
