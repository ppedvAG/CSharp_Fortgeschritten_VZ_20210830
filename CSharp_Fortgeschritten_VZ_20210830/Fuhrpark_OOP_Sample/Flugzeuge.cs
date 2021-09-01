using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_OOP_Sample
{
    public class Flugzeug : Fahrzeug, IRollbar
    {
        private double spannweite;
        private double maxFlughoehe;
        private List<string> passagierliste = new List<string>();
        
        public double Spannweite { get => spannweite; set => spannweite = value; }
        public double MaxFlughoehe { get => maxFlughoehe; set => maxFlughoehe = value; }
        public List<string> Passagierliste { get => passagierliste; set => passagierliste = value; }

        public Flugzeug()
        {

        }

        public Flugzeug(string marke, int baujahr, int maxGeschwindigkeit, string farbe, int spannweite, int maxFlughoehe)
            : base(baujahr, marke, maxGeschwindigkeit, farbe)
        {
            this.Spannweite = spannweite;
            this.MaxFlughoehe = maxFlughoehe;
        }

       

        public int RaederanzahlZumLenken { get; set; }
        public int RaederAnzahl { get; set; }
    }
}
