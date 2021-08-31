using System;
using System.Threading.Tasks;

namespace AsyncAwaitSampe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Mit Task Objekt
            Task<string> task = Task.Run(DayTime);
            Task myTask = task.ContinueWith(task => ShowDayTime(task.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            myTask.Wait();

            string theCoolerREturnValue = await Task.Run(DayTime);
            await task.ContinueWith(task => ShowDayTime(task.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
        }
        
        public static string DayTime()
        {
            DateTime date = DateTime.Now;

            return date.Hour > 17
                ? "evening"
                : date.Hour > 12
                ? "afternoon"
                : "morning";
        }


        public static void ShowDayTime(string result)
        {
            Console.WriteLine(result);
        }
    }
}
