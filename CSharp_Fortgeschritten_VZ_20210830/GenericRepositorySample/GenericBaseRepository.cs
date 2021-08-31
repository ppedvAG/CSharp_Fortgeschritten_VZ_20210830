using GenericRepositorySample.Traits;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositorySample
{
    public class GenericBaseRepository<T> : ISelectCommand<T>, IDeleteCommand<T>, IAddCommand<T>, IUpdateCommand<T>
    {

        private DbContext _dbContext;

        public GenericBaseRepository()
        {
            //_dbContext = new DbContext()
        }
        public void Add(T item)
        {
            //_dbContext.Set<T>().Add(item);
        }

        public void Add(T[] items)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, T item)
        {
            throw new NotImplementedException();
        }
    }
}
