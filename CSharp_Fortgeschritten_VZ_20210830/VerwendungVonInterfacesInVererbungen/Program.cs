using System;
using System.Collections.Generic;

namespace VerwendungVonInterfacesInVererbungen
{
    class Program
    {
        static void Main(string[] args)
        {
            HorrorSchockerCabinet schockerKabinett = new HorrorSchockerCabinet();

            if (schockerKabinett is IFSK16Check check)
            {
                check.Check(15);
            }

           
            IList<JahrmarktStand> jahresmarktStandCollection = new List<JahrmarktStand>();

            jahresmarktStandCollection.Add(new MirrorCabinet());

            jahresmarktStandCollection.Add(new AutoScooter());

            jahresmarktStandCollection.Add(new HorrorSchockerCabinet());

            jahresmarktStandCollection.Add(new AutoScooter());


            foreach(JahrmarktStand currentStand in jahresmarktStandCollection)
            {
                //if (currentStand is HorrorSchockerCabinet horrorcabinet)
                //{
                //    if (horrorcabinet is IFSK16Check alterspruefung)
                //    {
                //        //Prüfung des Alters 
                //        bool valid = alterspruefung.Check(15);
                //    }
                //}

                if (currentStand is IFSK16Check alterspruefung)
                {
                    //Prüfung des Alters 
                    bool valid = alterspruefung.Check(15);
                }
            }
        }
    }
    public interface IFSK16Check
    {
        public bool Check(int Alter)
        {
            return (Alter >= 16);
        }
    }

    public class JahrmarktStand
    {
        //Öffnungszeiten 

        //Miete des Standes
    }

    public class MirrorCabinet : JahrmarktStand
    {

    }

    public class AutoScooter : JahrmarktStand
    {

    }

    public class HorrorSchockerCabinet : JahrmarktStand, IFSK16Check
    {

    }


    public class DieGefaehrlichsteAchterbahnDerWelt : JahrmarktStand, IFSK16Check
    {

    }
}
