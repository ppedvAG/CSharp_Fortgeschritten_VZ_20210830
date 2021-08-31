using System;

namespace DelegateWithCallback
{
    public delegate void MessageDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            MessageDelegate messageDelegate = new MessageDelegate(FinishResultMethode);

            MethodWithCallback(11, 22, messageDelegate);


            Action<string> actionMessageDelegate = new Action<string>(FinishResultMethode);
            MethodWithCallback(11, 22, actionMessageDelegate);
        }


        public static void MethodWithCallback(int param1, int param2, MessageDelegate messageDelegate)
        {
            //Mach etwas un berechne die Methode

            //Callback Delegates werden immer am schluss einer Methode verwendet. 
            messageDelegate("The Number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }

        public static void MethodWithCallback(int param1, int param2, Action<string> messageDelegate)
        {
            //Es wird hier viel berechnet... 
            messageDelegate("The number is " + (param1 + param2).ToString()); //Invoke auf FinishResultMethode
        }


        public static void FinishResultMethode(string message)
        {
            Console.WriteLine(message);
        }
    }
}
