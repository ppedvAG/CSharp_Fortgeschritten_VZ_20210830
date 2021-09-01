using System;
using System.Dynamic;

namespace DynamicObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myObj = new ExpandoObject(); //dynamic + ExpandoObject

            myObj.Vorname = "Max";
            myObj.Nachname = "Mustermann";


            Console.WriteLine(myObj.Nachname);
            myObj.DiesePropertyKennSicherKeine = 123;
        }
    }
}
