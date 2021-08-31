using System;
using System.Threading;

namespace _004_ThreadWithReturnValueAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string retStr = string.Empty;
            string meinText = "Hello World";
            
            Thread thread = new Thread(() =>
            {
                //Anonyme Methode läuft im thread und ruft StringToUpper auf


                //Ab hier befinden wir uns im seperaten Thread
                retStr = StringToUpper(meinText);
            });

            thread.Start();
            thread.Join();


            Console.WriteLine(retStr);
            Console.ReadLine();
        }


        public static string StringToUpper(string param1)
        {
            return param1.ToUpper(); //Alles wird in Großbuchstaben zurückgegeben
        }
    }
}
