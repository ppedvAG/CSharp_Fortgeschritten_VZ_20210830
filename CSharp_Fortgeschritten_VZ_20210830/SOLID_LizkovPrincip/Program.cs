using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_LizkovPrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LottozahlenGenerator
    {
        public virtual int[] GenerateLottozahlen()
        {
            Random r = new Random();

            IList<int> lottozahlen = new List<int>();
            lottozahlen.Add(r.Next(1, 49));
            lottozahlen.Add(r.Next(1, 49));
            lottozahlen.Add(r.Next(1, 49));
            lottozahlen.Add(r.Next(1, 49));
            lottozahlen.Add(r.Next(1, 49));
            lottozahlen.Add(r.Next(1, 49));
            lottozahlen.Add(r.Next(1, 49));


            return lottozahlen.ToArray();
        }
    }


    //Diese klasse verstößt gegen das Lizkovische Prinzip 
    public class Wetterdaten : LottozahlenGenerator
    {
        public override int[] GenerateLottozahlen()
        {
            return base.GenerateLottozahlen();
        }
    }
}
