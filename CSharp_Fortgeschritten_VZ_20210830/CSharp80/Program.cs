using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp80
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();


            Fahrzeug f = new Fahrzeug();
            f.GebeGas();
            f.Bremse();

            Fahrzeug.KmhToMph(123);

            await GebeZahlenAus();




            #region Strings
            int a = 10;
            string name = "Muster";
            Console.WriteLine("Hallo {0}", name);
            Console.WriteLine("Hallo {0}, Zahl des Tages {1}", name, a);

            //Interpolation
            Console.WriteLine($"Hallo {name}, Zahl des Tages {a}");


            //String Verkettungen mit +-Operator sind sehr langsam -> StringBuilder ist die bessere Variante
            Console.WriteLine("Hallo " +  name +  "Zahl des Tages " + a);


            //@ -Zeichen in Strings -> Verbatim String
            Console.WriteLine("Hallo lieber Sportsfreunde \n Hier ist Werner vom Sportsutdio \t");

            string dataPath = "C:\\Windows";

            string dataPath2 = @"C:\Windows\";

            string subDirectory = "Temp";
            string dataPath3 = @$"C:\Windows\{subDirectory}";
            #endregion


            ICar car = new Car(); //Dependency Injection hat man mehr Möglichkeit
            car.Beschleunigen(12);
            car.Bremsen();

            Car car1 = new Car();
            car1.Bremsen();
            car1.Beschleunigen(12);

            ICar2 car2 = new Car2();
            car.Beschleunigen(12); //Klassenimplementierung in Car2 wird aufgerufen
            car.Bremsen(); //Interface Implementierung wird aufgerufen 

            Car2 car3 = new Car2();
            car3.Beschleunigen(12);
            //car3.Bremsen(); findet er so nicht, weil die Klasse Car2 keine Bremsen-Methode implementiert hat

            ((ICar2)car3).Bremsen(); //Nach interface cast können wir die Methode callen 


        }



        #region NullAble Datentypen (generel, klein C# 8 Feature)
        public void NullableDataTypesSample(int? myNullableParam)
        {
            int i = default; // 0 wird gesetzt

            int? myNullableDataType = null; //Initialisierung mit Nullable DataTypes 
            myNullableDataType = 123; 


            if (!myNullableParam.HasValue) //wurde ein Integer Wert gesetzt
            {
                throw new AggregateException();
            }
            else
            {
                Console.WriteLine(myNullableParam.Value); //Value hat nur ein GET
            }


        }
        #endregion

        #region AsynEnumarable with yield return

        //https://docs.microsoft.com/de-de/aspnet/core/web-api/action-return-types?view=aspnetcore-5.0
        // Wird verwendet bei Service Layer / Clients z.b grpc oder WebAPI (Return Values) 
        public static async IAsyncEnumerable<int> GeneriereZahlen()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        } //Hier verlässt er die Methode

        public static async Task GebeZahlenAus()
        {
            await foreach (var zahl in GeneriereZahlen())
            {
                Console.WriteLine(zahl);
            }
        }

        #endregion

       
    }

    public class Fahrzeug
    {

        public int Geschwindigkeit { get; set; } = 0;
        public void GebeGas()
        {
            Geschwindigkeit += 5;
        }

        public void Bremse()
        {
            Geschwindigkeit -= 5;
        }

        public static float KmhToMph(int kmh)
        {
            return kmh * 1.3f; 
        }
    }
        
    public class Person
    {
        public int MyAge()
        {
            int alter = 30;
           
            static int OffSettalter (int Alter)
            {
                return Alter + 5;
            }

            return OffSettalter(alter);
        }
    }


    #region Asynchrones Enumerable mit yield return
    #region Asynchrone Stream //Wird bei ServiceLayer Methoden gerne verwendet. (WebAPI oder GRPC


    //Auflösen eines Namespace -> [STRG] + [.] -> using [Namespace] wird dann optional angeboten. 



    #endregion
    #endregion


    #region Interface C# 8.0 

    public interface ICar
    {
        void Bremsen();
        void Beschleunigen(int offsetKMH);
    }

    public class Car : ICar
    {
        public void Beschleunigen(int offsetKMH)
        {
            //Bitte ausimplementieren
        }

        public void Bremsen()
        {
            //Bitte ausimplementieren
        }
    }



    public interface ICar2
    {
        void Bremsen()
        {
            Console.WriteLine("Wir bremsen auf 0 kmh");
        }
        void Beschleunigen(int offsetKMH);
    }


    public class Car2 : ICar2
    {
        public void Beschleunigen(int offsetKMH)
        {
            
        }
    }


    #endregion
}
