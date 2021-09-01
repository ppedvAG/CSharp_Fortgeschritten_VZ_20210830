using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_OOP_Sample
{
    public class Fahrzeug
    {
        private int baujahr;
        private string marke;
        private double aktGeschwindigkeit;
        private double maxGeschwindigkeit;


        #region Konstruktor
        // ctor + tab + tab = leerer Default Konstruktor
        public Fahrzeug()
        {
            this.AktGeschwindigkeit = 0;
            this.MotorLaeuft = false;

            AnzahlErstellterFahrzeuge++;
        }

        public Fahrzeug(int baujahr, string marke, double maxGeschw)
            : this()
        {

            this.Baujahr = baujahr;
            this.Marke = marke;
            this.MaxGeschwindigkeit = maxGeschw;
        }

        public Fahrzeug(int baujahr, string marke, double maxGeschw, string farbe)
            : this(baujahr, marke, maxGeschw)
        {
            this.Farbe = farbe;
        }
        #endregion

        #region Properties
        //Auto Property -> Variable wird unsichtbar im Hintergrund beim Kompilieren angelegt
        // In einer Auto-Property ist es nicht möglich eine Validierung einzubauen, wird für Daten-Container gerne verwendet...z.b .NET Framework Poco-Onjekte
        public virtual string Farbe { get; set; }
        public bool MotorLaeuft { get; set; }
        public int Baujahr { get => baujahr; set => baujahr = value; }

        public string Marke { get => marke; set => marke = value; }

        // fahrzeug1.AktGeschwindigkeit = 343 
        public double AktGeschwindigkeit
        {
            get
            {
                return aktGeschwindigkeit;
            }

            set
            {
                //Zugriff mit Validierung
                if (value >= 0)
                    aktGeschwindigkeit = value;
                else
                    aktGeschwindigkeit = 0;
            }
        }
        public double MaxGeschwindigkeit { get => maxGeschwindigkeit; set => maxGeschwindigkeit = value; }
        // Properties können auch nur ein Get-Segment
        public string Tacho
        {
            get
            {
                //Properties kann man mit Variablen kompinieren. 
                string tachAntzeige = $"{aktGeschwindigkeit} - {maxGeschwindigkeit}";
                return tachAntzeige;
            }
        }

        #endregion

        #region Methoden
        public void StarteMotor()
        {
            this.MotorLaeuft = true;
        }

        public void StoppeMotor()
        {
            this.MotorLaeuft = false;
        }

        public void Beschleunigung(int a)
        {
            if (this.MotorLaeuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                {
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                }
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;
            }
        }
        #endregion

        #region Static 
        public static int AnzahlErstellterFahrzeuge { get; private set; } = 0;


        public static string ZeigeAnzahlFahrzeuge()
        {
            return $"Es wurden {AnzahlErstellterFahrzeuge} Fahrzeug Objekte erstellt";
        }

        public static double MphTOKmh(double mph)
        {
            return mph * 1.60934;
        }

        public static double KmhTOMph(double kmph)
        {
            return 0.6214 * kmph;
        }
        #endregion
    }
}
