/* Lägg till en ny metod av typen bool som returnerar true
om personen är myndig (minst 18 år gammal).
För att räkna ut ålder kan du använda:
DateTime Now = DateTime.Now;
int age = Now.Year - birthday.Year */
using System;

namespace Uppgift_6
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
