using System;

namespace _004_Polymorphiesmus_Virtual_sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public sealed class MySealedClass
    {
        public string Text = "HAllo";
    }


    //Severity	Code	Description	Project	File	Line	Suppression State
    //Error CS0509  'MyChildClass': cannot derive from sealed type 'MySealedClass'	

    //public class MyChildClass : MySealedClass
    //{

    //}

}
