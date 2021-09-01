using System;

namespace _002_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch human = new Mensch(33, "Berlin");


            Lebewesen lebewesen = new Mensch(33, "Berlin");
            Mensch mensch = (Mensch)lebewesen;

        }
    }



    //Basisklasse
    public class Lebewesen
    {
        public int Alter { get; set; }

        public Lebewesen(int Alter)
        {
            this.Alter = Alter;
        }

        public void Schlafen()
        {
            //zZZZZzzzZZ
        }
    }


    //abgeleitetede oder vererbte Klasse
    public class Mensch : Lebewesen
    {
        public string Wohnort { get; set; }

        public Mensch(int Alter, string Wohnort)
            : base(Alter) //hier rufen wir die Basi
        {
            this.Wohnort = Wohnort;
        }

        public void Lesen()
        {
        }

    }


    public class Katze : Lebewesen
    {
        public Katze(int Alter)
            : base(Alter)
        {

        }

        public void Schnurren()
        {
            //Katze schnurrt
        }
    }
}
