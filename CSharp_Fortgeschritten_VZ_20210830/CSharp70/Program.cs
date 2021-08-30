using System;

namespace CSharp70
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Referenztypen und Wertetypen
            //Wertetypen  -> int, long, short, byte, bool, uint, structs, char

            int alter = 19;
            WerteTypÄndern(alter); //Eine Kopie wird übergeben

            //cw + tab + tab -> Console.WriteLine();
            Console.WriteLine(alter);


            string eingabe = "Hallo ";
            //Referenztypen -> string, class, interfaces

            //Mit String
            ReferenzTypenWithString(eingabe);
            Console.WriteLine(eingabe);

            //Mit Klasse
            Person person = new Person();
            person.Name = "Hallo ";
            ReferenzTypenWithClass(person); //Speicheradresse der Klasse wird übergeben 
            Console.WriteLine(person.Name);
            #endregion

            #region .NET Datentypen vs C# Datentypen
            int iamANETInteger = 123;

            Int32 iamANativeNETDataType = 123; //siehe Diagram -> Datentypen in .NET
            #endregion

            #region Wertetypen als Referenz

            IntCheck();
            #endregion


            string name = "Muster";
            int alter1 = 20;

            // Aus mehreren Variablen initialisieren wir ein Object

            //Variablen werden im Konstruktor den Member Variablen zugewiesen
            Person p = new Person(name, alter1);




            //Tupel 

            var tupelRückgabe = person.TupelAusgabePeron();

            Console.WriteLine(tupelRückgabe.Vorname);
            Console.WriteLine(tupelRückgabe.Name);
            Console.WriteLine(tupelRückgabe.Alter);

            //Deconstruct ist eine Konvention!
            var (firstname, lastname, age) = p; //Deconstruct wird in C# 9.0 weiter verwendet -> Gehört zum Reportaire einer Klassen (kann-regel) 
            var (firstname1, lastname1) = p;

            //(int Age1, string vn)  = p.TestMethode(); -> geht so nicht -> einfacher Tupel-Rückgabe wäre besser + 

            decimal myMoney = 1_000_000m;
            Console.WriteLine(myMoney);

            float myFloatVariable = 123.23f;
            Console.WriteLine(myFloatVariable);
        }

        private static void WerteTypÄndern (int i) //i ist die Kopie und hat einen eigenen Speicherplatz 
        {
            i++;
        }

        private static void ReferenzTypenWithString(string name)
        {
            name += " Welt";
        }

        private static void ReferenzTypenWithClass(Person person)
        {
            person.Name += " Welt";
        }

        private static void IntCheck()
        {
            string eingabe = "123456";
            int ausgabe; 

            if (int.TryParse(eingabe, out ausgabe)) //Hier wird geprüft, ob der String in ein Integer konventiert werden kann 
            {
                // int ausgabe hat den Wert von Eingabe übernommen (ist konventierbar) 
                Console.WriteLine(ausgabe);
            }

            int ausgabe2;
            if (MyTryParse(eingabe, out ausgabe2))
            {
                Console.WriteLine(ausgabe2);
            }
        }

        private static bool MyTryParse(string eingabe, out int toCheck)
        {
            for (int i = 0; i < eingabe.Length; i++)
            {
                if (!char.IsDigit(eingabe[i]))
                {
                    throw new ArgumentException();
                }
            }

            toCheck = Convert.ToInt32(eingabe);
            return true;
        }


        public static void PatternMatching (object o)
        {
            if (o is null)
            {
                return;
            }

            if (o is int i) //Prüft ob object eine Interger ist, wenn ja, wird dieser in die Variable i gecastet
            {
                Console.WriteLine(i);
            }
        }


        
    }


    public class Person
    { 
        public string Name { get; set; }

        public string Vorname { get; set; }

        public int Alter { get; set; }

        //ctor + tab + tab 
        public Person()
        {

        }

        public Person(string Vorname, string Name, int Alter)
        {
            this.Name = Name;
            this.Alter = Alter;
            this.Vorname = Vorname;
        }


        public (string Vorname, string Name, int Alter) TupelAusgabePeron ()
        {
            return (Vorname, Name, Alter);
        }

        public void Deconstruct(out string Vorname, out string Nachname, out int Alter)
        {
            Vorname = this.Vorname;
            Nachname = this.Name;
            Alter = this.Alter;
        }

        public void Deconstruct(out string Vorname, out string Nachname)
        {
            Vorname = this.Vorname;
            Nachname = this.Name;
            Alter = this.Alter;
        }


        public void TestMethode(out int Alter, out string Nachname)
        {
            Alter = this.Alter;
        }
    }
}
