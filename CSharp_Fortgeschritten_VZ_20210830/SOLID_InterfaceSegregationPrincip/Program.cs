using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SOLID_InterfaceSegregationPrincip
{
    class Program
    {
        static void Main(string[] args)
        {

            #region BadCocde
            IRepository<Person> repo = new RepositoryBase<Person>();
            //repo.GetAll() / repo.GetById / repo.Delete / repo.Insert / repo.Update

            IReadRepository<Person> readRepository = new RepositoryBase<Person>(); //User hat nur LEserechte
            readRepository.GetAll();
            readRepository.GetById(123);
            readRepository.GetByStatement(n => n == 3);



            IRepository<Person> repository = new RepositoryBase<Person>();
            repository.Insert(new Person(2, "Harry"));
            repository.Update(2, new Person(2, "Tester"));
            repository.GetAll();

            #endregion

            #region InterfaceSegregationPrincip
            IABC abc = new MyABC();
            
            
            
            IA a = new MyABC();
            a.MethodeA(); 
            #endregion

        }
    }

    public record Person(int Id, string Name);



    #region BadCode 
    public interface IReadRepository<T>
    {
        IList<T> GetAll();

        IList<T> GetByStatement(Expression<Func<int, bool>> predicate); //Where Klausen

        T GetById(int Id);
    }

    public interface IRepository<T> : IReadRepository<T>
    {
        public void Insert(T item);
        public void Update(int Id, T modifiedItem);

        public void Delete(int Id);
    }


    public class RepositoryBase<T> : IRepository<T>
    {

        //DbContext -> Verbindung zu DB
        public void Delete(int Id)
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

        public IList<T> GetByStatement(Expression<Func<int, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, T modifiedItem)
        {
            throw new NotImplementedException();
        }
    }
    #endregion


    #region Goode Code

    public interface IA
    {
        void MethodeA();
    }

    public interface IB
    {
        void MethodeB();
    }

    public interface IC
    {
        void MethodeC();
    }

    public interface IABC : IA, IB, IC
    {
        //kann man weiteres noch implementieren 
    }

    public class MyABC : IABC
    {
        public void MethodeA()
        {
            throw new NotImplementedException();
        }

        public void MethodeB()
        {
            throw new NotImplementedException();
        }

        public void MethodeC()
        {
            throw new NotImplementedException();
        }
    }
    #region
}
