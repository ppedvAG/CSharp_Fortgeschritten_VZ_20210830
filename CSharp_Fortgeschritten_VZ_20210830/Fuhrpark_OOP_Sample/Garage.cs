using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_OOP_Sample
{
    public class Garage
    {
        private List<Fahrzeug> fahrzeugListe = new List<Fahrzeug>();
        public int MaxParkplaetze { get; set; } = 10; 


        public Garage()
        {

        }


        public Garage(int Parkpülaetze)
        {
            MaxParkplaetze = Parkpülaetze;
        }


        public List<Fahrzeug> FahrzeugListe { get => fahrzeugListe; set => fahrzeugListe = value; }

        public void ParkeFahrzeugInGarage(Fahrzeug fahrzeug)
        {
            if (MaxParkplaetze > FahrzeugListe.Count)
                FahrzeugListe.Add(fahrzeug);
        }

        public void WelcheFahrzeugeSindInDerGarage()
        {
            int pkwCounter = 0;
            int flugzeugCounter = 0;
            int schiffCounter = 0;


            foreach (Fahrzeug currentFahrzeug in FahrzeugListe)
            {

                if (currentFahrzeug is PKW)
                {
                    if (currentFahrzeug.Marke == "Ferrarie")
                    {
                        //...
                        //Ferrarie muss nach Italien zur Repatur 
                    }
                    pkwCounter++;
                }
                else if (currentFahrzeug is Flugzeug)
                {
                    flugzeugCounter++;
                }
                
                else if (currentFahrzeug is Schiff)
                {
                    schiffCounter++;
                }
            }

            Console.WriteLine($"---- Garageninventar ---- ");
            Console.WriteLine($"PKW-Anzahl:\t\t{pkwCounter} ");
            Console.WriteLine($"Flugzeug-Anzahl:\t{flugzeugCounter}");
            Console.WriteLine($"Schiff-Anzahl: \t\t{schiffCounter}");

        }


        public IList<Fahrzeug> WelcheFahrzeugeKönnenWeggerolltWerden()
        {
            IList<Fahrzeug> retList = new List<Fahrzeug>();

            foreach (Fahrzeug fahrzeug in FahrzeugListe)
            {
                if (fahrzeug is IRollbar)
                {
                    retList.Add(fahrzeug);
                }
            }


            return retList;
        }
    }
}
