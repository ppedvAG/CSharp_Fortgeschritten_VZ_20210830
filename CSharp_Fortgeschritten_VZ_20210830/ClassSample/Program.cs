using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug fahrzeug = new Fahrzeug("VW", "Polo", 30);

            fahrzeug.Beschleunigen(12);
            fahrzeug.Bremsen();

            Console.WriteLine(Fahrzeug.KmhTOMph(100));



            Console.WriteLine(Fahrzeug.MphTOKmh(100));
        }
    }





    public class Fahrzeug
    {


        #region Field And Properties
        //Fields
        private string _brand;


        //Properties kapseln die Field vor direkten Zugriff
        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                //Validierungen

                if (value == string.Empty)
                    throw new ArgumentException();

                _brand = value; 
            }
        }



        //Auto-Property -> das Field wird beim kompilieren "hinzugedichtet"
        public string Model { get; set; }


        public int PS { get; set; }

        #endregion


        //ctor + tab + tab -> Konstruktor
        public Fahrzeug(string Brand, string Model)
        {
            this.Brand = Brand;
            this.Model = Model;
        }

        public Fahrzeug(string Brand, string Model, int PS)
            : this(Brand, Model)
        {
            this.PS = PS;
        }


        public void Beschleunigen (int offSetKmH)
        {
            //Beschleunigt
        }

        public void Bremsen ()
        {
            //Bremsen 
        }


        public static double MphTOKmh(double mph)
        {
            return mph * 1.60934;
        }

        public static double KmhTOMph(double kmph)
        {
            return 0.6214 * kmph;
        }
    }
}
