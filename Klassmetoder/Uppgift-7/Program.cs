using System;

namespace Uppgift_7
{
    class Elev
    {
        public string förnamn;
        public string efternamn;
        public DateTime födelseDatum;
        public double längd;
        public double vikt;

        public bool Myndig()
        {
            int age = DateTime.Now.Year - födelseDatum.Year;
            return age >= 18;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Student!");
        }
    }
}
