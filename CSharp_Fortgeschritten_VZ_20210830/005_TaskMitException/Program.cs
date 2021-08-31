﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace _005_TaskMitException
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = null, t2 = null, t3 = null, t4 = null;

            try
            {
                t1 = new Task(MachEinenFehler1);
                t1.Start();

                t2 = Task.Factory.StartNew(MachEinenFehler2);

                t3 = Task.Run(MachEinenFehler3);

                t4 = Task.Run(MachKeinenFehler);

                //Hier bekommen mit, ob die Tasks sauber durchgelaufen sind oder eine Exception geschmissen haben 
                Task.WaitAll(t1, t2, t3, t4); //Warten bis alle angegebenen Tasks fertig sind :-) 
                                              //Hier zeigen sich die Exception in den jeweiligen Tasks
            }
            catch (AggregateException ex) //AggregateException wird für Task-Fehler verwendet 
            {
                foreach (Exception innerException in ex.InnerExceptions)
                    Console.WriteLine(innerException.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (t4.IsCompletedSuccessfully)
            {
                Console.WriteLine("Task 4 wurde sauber abgearbeitet");
            }


            if (t3.IsCompleted)
                Console.WriteLine("Task 3 ist fertig!");

            if (t3.IsFaulted)
                Console.WriteLine("Task 3 hat ein Fehler!");

            if (t3.IsCanceled)
                Console.WriteLine("Task 3 wird abgebrochen");


            Console.ReadKey();

        }



        private static void MachEinenFehler1()
        {
            Thread.Sleep(3000);
            throw new DivideByZeroException();
        }

        private static void MachEinenFehler2()
        {
            Thread.Sleep(6000);
            throw new StackOverflowException();
        }

        private static void MachEinenFehler3()
        {
            Thread.Sleep(9000);
            throw new OutOfMemoryException();
        }

        private static void MachKeinenFehler()
        {
            Console.WriteLine("Einen schönen Tag :-) ");
        }
    }
}
