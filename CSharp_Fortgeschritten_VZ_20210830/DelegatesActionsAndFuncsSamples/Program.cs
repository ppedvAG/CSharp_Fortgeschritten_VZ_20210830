using System;

namespace DelegatesActionsAndFuncsSamples
{
    class Program
    {
        delegate int NumbChange(int n);
        delegate int CalculationDelegate(int zahl1, int zahl2);


        delegate void VoidAndNoParamDelegegate(); // Action ist besser  -> Action a1 = new Action(A);
        static void Main(string[] args)
        {
            #region Sample1 Delegate
            NumbChange numbChange = new NumbChange(AddNumber); //Methodenzeiger wird übergeben
            int result = numbChange(10); //Invoken die Methode

            numbChange += SubNumber;
            result = numbChange(10);

            numbChange -= AddNumber;
            result = numbChange(10);

            CalculationDelegate calculationDelegate = new CalculationDelegate(Addition);
            result = calculationDelegate(15, 10);
            #endregion


            Action a1 = new Action(A);
            a1 += B;
            a1();

            // Meine Methode die ich hier an diesem Action Delegate dranhänge, verwendet einen integer Parameter
            Action<int> actionWithOneParameter = new Action<int>(C);
            actionWithOneParameter(123);


            //Letzter Datentyp ist Rückgabewert
            Func<int, int, int> func = new Func<int, int, int>(Addition);
            int result2 = func(22, 22);
            
        }

        public static int AddNumber(int number)
        {
            return number + 5;
        }

        public static int SubNumber(int number)
        {
            return number - 3;
        }

        public static int Addition(int z1, int z2)
        {
            return z1 + z2;
        }

        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }


        public static void C(int zahl)
        {
            Console.WriteLine("C" + zahl);
        }

    }
}
