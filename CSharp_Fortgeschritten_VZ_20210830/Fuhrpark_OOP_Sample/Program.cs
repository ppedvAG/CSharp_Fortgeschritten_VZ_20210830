using System;

namespace Fuhrpark_OOP_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Flugzeug flugzeug = new Flugzeug("Lufthansa", 2001, 500, "blau", 22, 11000);
            Flugzeug flugzeug1 = new Flugzeug("Fogger Doppedecker", 1912, 50, "Rot", 10, 2000);

            PKW pkw1 = new PKW("Ferrarie", 1955, 220, "Rot", 2, 4);
            PKW pkw2 = new PKW("Trappi", 1955, 80, "Mausegrau", 4, 4);
            PKW pkw3 = new PKW("Mercedez", 2020, 260, "Schwarz", 4, 4);


            Schiff schiff = new Schiff("Gorck Fork", 1867, 15, 5);


            Garage dagobertsGarage = new Garage();
            dagobertsGarage.ParkeFahrzeugInGarage(flugzeug);
            dagobertsGarage.ParkeFahrzeugInGarage(flugzeug1);
            dagobertsGarage.ParkeFahrzeugInGarage(pkw1);
            dagobertsGarage.ParkeFahrzeugInGarage(pkw2);
            dagobertsGarage.ParkeFahrzeugInGarage(pkw3);
            dagobertsGarage.ParkeFahrzeugInGarage(schiff);

            dagobertsGarage.WelcheFahrzeugeSindInDerGarage();


            Console.WriteLine($"Anzahl aller erstellen Fahrzeuge {Fahrzeug.AnzahlErstellterFahrzeuge}");


        }
    }
}
