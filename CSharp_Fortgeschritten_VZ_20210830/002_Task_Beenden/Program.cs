using System;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Task_Beenden
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource(); //Ab .NET 4.0 

            //Task task = Task.Factory.StartNew(MeineMethodeMitAbbrechen, cts);

            Task easyTask = new Task(MeineMethodeMitAbbrechen, cts);
            easyTask.Start();


            Thread.Sleep(5000);
            cts.Cancel();

            //cts.CancelAfter(5000);
        }

        private static void MeineMethodeMitAbbrechen(object param) //übergebene CancellationTokenSource und diese ist ein REFERENZTYP
        {
            CancellationTokenSource source = (CancellationTokenSource)param;


            while (true)
            {
                Console.WriteLine("zzzzZZZzzzZZZzzzZZZzzzZZZZZ");
                Thread.Sleep(50);


                if (source.IsCancellationRequested) //wurde Cancelation aktiviert?
                    break;
            }
        }
    }
}
