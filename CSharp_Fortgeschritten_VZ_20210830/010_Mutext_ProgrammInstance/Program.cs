﻿using System;
using System.Threading;

namespace _010_Mutext_ProgrammInstance
{
    class Program
    {
        static Mutex _mutex;
        
        
        static void Main(string[] args)
        {
            if (!Program.IsSingleInstance())
            {
                Console.WriteLine("More than one instance");
            }
            else
                Console.WriteLine("one Instance");

            Console.ReadLine();
        }

        static bool IsSingleInstance()
        {

            if (Mutex.TryOpenExisting("ABC", out _mutex))
            {
                return false;
            }
            else
                return true; 


            //try
            //{
            //    Mutex.OpenExisting("ABC");
            //}
            //catch
            //{
            //    Program._mutex = new Mutex(true, "ABC"); //ERste Programm Instanz legt instanziiert das Mutex Object
            //    return true;
            //}


            ////Zweite Programm Instance verlässt hier die Methode. 
            //return false; 
        }
    }
}
