using System;

namespace _004_Polymorphiesmus_Virtual_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Fahrzeug
    {
        public virtual string WasBinIch()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Auto : Fahrzeug
    {
        //durch Schluesselwort new eine neue Methode erzeugt
        //ueberschreibt die virtuelle Methode der Basisklasse nicht
        //public new string WasBinIch()
        //{
        //    return "Ich bin ein Auto";
        //}

        public new string WasBinIch()
        {
            return "Ich bin ein Auto";
        }
    }

    public class ElectroCar : Auto
    {

        //Diese Methode geht nicht mehr mit Ovverice -> Dank new 
        //public override string WasBinIch()
        //{
        //    return "Ich bin ein Elektro Auto"
        //}
    }
}
