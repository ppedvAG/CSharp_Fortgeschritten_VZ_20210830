using System;

namespace _005_Polymorphiesmus_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public abstract class Shape //Von Shape können wir keine Instanz erzeugen, weil die abstract ist. Abstrakte Klassen sind mehr als eine Vorlage zu sehen. 
    {
        public abstract int GetArea(); //Wenn eine Methode mit 'abstract' definiert wird, MUSS die Klasse auch mit abstract definiert werden!
    }

    public class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => side * side;
    }
}
