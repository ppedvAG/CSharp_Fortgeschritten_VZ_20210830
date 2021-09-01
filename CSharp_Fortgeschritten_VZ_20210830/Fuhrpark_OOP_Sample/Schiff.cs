using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_OOP_Sample
{
    public class Schiff : Fahrzeug
    {
        //public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

        //public SchiffsTreibstoff Treibstoff { get; set; }
        public double Tiefgang { get; set; }

        //public Schiff(string marke, int baujahr, double maxGeschwindigkeit, SchiffsTreibstoff treibstoff, double tiefgang)
        //    : base(baujahr, marke, maxGeschwindigkeit)
        //{
        //    this.Treibstoff = treibstoff;
        //    this.Tiefgang = tiefgang;
        //}

        public Schiff(string marke, int baujahr, double maxGeschwindigkeit,  double tiefgang)
            : base(baujahr, marke, maxGeschwindigkeit)
        {
            
            this.Tiefgang = tiefgang;
        }
    }

    public class Segelschiff : Schiff
    {
        public int Mastanzahl { get; set; }

        public int InsgesamtSegelFläche { get; set; }

        public Segelschiff(string marke, int baujahr, double maxGeschwindigkeit, double tiefgang, int Mastanzahl, int SegelFläche)
            :base(marke, baujahr, maxGeschwindigkeit, tiefgang)
        {
            this.Mastanzahl = Mastanzahl;
            this.InsgesamtSegelFläche = SegelFläche;
        }
    }


    public class Ruderboot : Schiff
    {
        public int AnzahlRuderer { get; set; }

        

        public Ruderboot(string marke, int baujahr, double maxGeschwindigkeit, double tiefgang, int AnzahlRuderer)
            : base(marke, baujahr, maxGeschwindigkeit, tiefgang)
        {
            this.AnzahlRuderer = AnzahlRuderer;
        }
    }

    public class MotorBoot : Schiff
    {
        public int PS { get; set; }



        public MotorBoot(string marke, int baujahr, double maxGeschwindigkeit, double tiefgang, int PS)
            : base(marke, baujahr, maxGeschwindigkeit, tiefgang)
        {
            this.PS = PS;
        }
    }




}
