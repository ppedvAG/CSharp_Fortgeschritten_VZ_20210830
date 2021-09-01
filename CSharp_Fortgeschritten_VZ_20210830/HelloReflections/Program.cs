using System;

using System.Reflection;


namespace HelloReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly repräsentiert eine geladene DLL 
            Assembly geladeneDll = Assembly.LoadFrom("Taschenrechner.dll");

            //Explizieter Zugruff auf die Rechner-Klasse in Taschenrechner.dll
            Type taschenrechnerTyp = geladeneDll.GetType("Taschenrechner.Rechner");

            object tr = Activator.CreateInstance(taschenrechnerTyp);

            //Lese die Methode aus -> Methode die Add heisst und hat zwei Parameter vom Typ int (bzw Int32)

            MethodInfo addInfo = taschenrechnerTyp.GetMethod("Add", new Type[] { typeof(Int32), typeof(Int32) });
            
            var result = addInfo.Invoke(tr, new object[] { 11, 22 });

            Console.WriteLine(result);
        }
    }
}
