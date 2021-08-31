using System;

using System.Threading; //Thread Klasse enthalten 

namespace _001_ThreadStarten
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MachEtwasInEinemThread); //Methoden-Zeiger übergeben
            thread.Start(); //Thread beginnt Methode aufzurufen und parallel zur Main - Methode abarbeiten


            //Wir wollen warten bis Methode MachEtwasInEinemThread fertig abgearbeitet ist
            thread.Join(); //Hier warten einmal :-) 

            for (int i = 0; i < 100; i++)
                Console.WriteLine("*");


            Console.ReadLine();
        }


        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("#");
        }
    }
}
