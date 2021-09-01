using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_OOP_Sample
{
    public class PKW : Fahrzeug, IRollbar
    {
        #region Auto-Properties
        public int AnzahlTueren { get; set; }
        public int AnzahlRaeder { get; set; }
        public int AnzahlRaederAktuell { get; set; }
        
        public int RaederAnzahl { get; set; }

        #endregion

        public PKW(string marke, int baujahr, double maxGeschwindigkeit, string farbe, int anzahlTueren, int anzahlRaeder)
            : base(baujahr, marke, maxGeschwindigkeit, farbe)
        {
            this.AnzahlTueren = anzahlTueren;
            this.AnzahlRaeder = anzahlRaeder;
        }
    }
}
