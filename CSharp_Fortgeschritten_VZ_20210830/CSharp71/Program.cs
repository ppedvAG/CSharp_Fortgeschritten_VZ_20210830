using System;

namespace CSharp71
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = default; // i = 0;
            DateTime date = default; //Guten Morgen Jsesus :-) 

            Print<int>(123);
            Print<string>("Hello liebe Teilnehmer");
        }

        public static void ZahlDesTages (int i = default) //optionaler Parameter -> wenn keine Zuweisung...wird default bzw der Wert 0 verwendet 
        {
            

            if (i == default)
            {
                Console.WriteLine(i);
            }

            if (i is default(int))
            {

            }

            i++;
        }

        //public static void ZahlDesTages(DateTime myDateTime = default) //optionaler Parameter -> wenn keine Zuweisung...wird default bzw der Wert 0 verwendet 
        //{
        //    if (myDateTime is default(DateTime))
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        static void Print<T>(T input)
        {
            switch (input)
            {
                case int i:
                    Console.WriteLine($"Integer: {i}");
                    break;
                case string s:
                    Console.WriteLine($"String: {s}");
                    break;

                default:
                    Console.WriteLine("Unbekannter Typ");
                    break; 
            }
        }
    }
}
