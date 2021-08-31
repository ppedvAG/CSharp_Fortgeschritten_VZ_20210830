using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample.Traits
{
    public interface ISelectCommand<T>
    {
        public IList<T> GetAll();
        public T GetById(int Id);
    }
}
