using System;

namespace EventAndEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();
            processBusinessLogic.CurrentPercentStatus += ProcessBusinessLogic_CurrentPercentStatus;
            processBusinessLogic.ProcessCompleted += ProcessBusinessLogic_ProcessCompleted;


            processBusinessLogic.StartProcess();





            ProcessBusinessLogic2 processBusinessLogic2 = new ProcessBusinessLogic2();
            processBusinessLogic2.ProcessCompleted += ProcessBusinessLogic2_ProcessCompleted;
            processBusinessLogic2.ProcessCompletedNew += ProcessBusinessLogic2_ProcessCompletedNew;
            processBusinessLogic2.StartProcess();
        }

        private static void ProcessBusinessLogic2_ProcessCompletedNew(object sender, EventArgs e)
        {
            MyEventArgs myEventArgs = (MyEventArgs)e;
            Console.WriteLine(myEventArgs.Uhrzeit.ToShortDateString());
        }

        private static void ProcessBusinessLogic2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Ich bin fertig :-)");
        }

        private static void ProcessBusinessLogic_ProcessCompleted()
        {
            Console.WriteLine("Ich bin fertig :-)");
        }

        private static void ProcessBusinessLogic_CurrentPercentStatus(int n)
        {
            Console.WriteLine($"Percent: {n}");
        }
    }
}
