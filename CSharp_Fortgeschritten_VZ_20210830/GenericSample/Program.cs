using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericSample
{
    class Program
    {
        private static IDictionary<int, string> dictBuffet = new Dictionary<int, string>();
        private static IDictionary<int, string> dictTeller = new Dictionary<int, string>();
       
        static void Main(string[] args)
        {
            IList<string> nameLise = new List<string>(); //array von 4 items 
            nameLise.Add("Harry");
            nameLise.Add("Emanuella");

            IList<int> zahlenListe = new List<int>();
            zahlenListe.Add(1);


            IDictionary<Guid, string> dict = new Dictionary<Guid, string>();

            dict.Add(Guid.NewGuid(), "Guten Tag");
            dict.Add(new KeyValuePair<Guid, string>(Guid.NewGuid(), "Halloooo :-)"));

            foreach(KeyValuePair<Guid, string> currentDictEntry in dict)
            {
                Console.WriteLine(currentDictEntry.Key.ToString());
                Console.WriteLine(currentDictEntry.Value);
            }

            //Zwei Listen (Eine Auswahl-Liste + eine Selected-Liste)


            LoadBuffetFromDB();

            NehmeEtwasVomBuffet(1);
            NehmeEtwasVomBuffet(3);
            NehmeEtwasVomBuffet(5);

            //Hash-Table ist der böser 
            Hashtable hashTable = new Hashtable();
            hashTable.Add(new DateTime(), "Hallo");


            //Besser

            IDictionary<int, Person> dictPersonen = new Dictionary<int, Person>();
            dictPersonen.Add(1,new Employee("Tester", 1234));



            DataStore<string, Guid> dataStore = new DataStore<string, Guid>();
            
            
            dataStore.DisplayDefault<int>();

            

        }

        private static IDictionary<int, string> LoadBuffetFromDB ()
        {
            IDictionary<int, string> loadedBuffet = new Dictionary<int, string>();
            loadedBuffet.Add(1, "Apfel");
            loadedBuffet.Add(2, "Orange");
            loadedBuffet.Add(3, "Birne");
            loadedBuffet.Add(4, "Sandwich");
            loadedBuffet.Add(5, "Eis");

            return loadedBuffet;
        }

        private static IDictionary<int, string> ShowUnseletedFood (IDictionary<int, string> loadedBuffet)
        {
            IDictionary<int, string> unseletedFood = new Dictionary<int, string>();

            foreach (KeyValuePair<int, string> foodItem in loadedBuffet)
            {
                if (!dictTeller.ContainsKey(foodItem.Key))
                    unseletedFood.Add(foodItem);
            }


            return unseletedFood;

        }

        public static void NehmeEtwasVomBuffet(int index)
        {
            if (!dictTeller.ContainsKey(index))
            {
                string currentFood = dictBuffet[index];

                dictTeller.Add(index, currentFood);


                //Essen verschwinden aus dem Buffet 
                dictBuffet.Remove(index);

            }
        }

        public void AktualisiereBuffetDictionary()
        {

        }
    }

    public record Person (string Name);
    public record Employee : Person
    {
        public int Gehalt { get; set; }
        public Employee(string Name, int Gehalt)
            : base(Name)
        {
            this.Gehalt = Gehalt;
        }
    }




    public class DataStore<T, ABC>
    {
        private T[] _data = new T[10];

        private ABC myABCDataType;

        public ABC MyABC
        {
            get => myABCDataType;
            set => myABCDataType = value;
        }

        public T[] Data
        {
            get => _data;
            set => _data = value;
        }

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        public void DisplayDefault<MyType>()
        {
            MyType item = default(MyType);

            Console.WriteLine($"Default value of {typeof(MyType)} is {(item == null ? "null" : item.ToString())}.");
        }
    }
}
