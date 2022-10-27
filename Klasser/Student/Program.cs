using System;

namespace Stundent
{
    class Elev
    {
        public string förnamn;
        public string efternamn;
        public DateTime födelseDatum;
        public double längd;
        public double vikt;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello student!");

            // Använd klassen Elv för att skapa en variabel
            Elev elev1 = new Elev();
            elev1.förnamn = "Ashkan";
            elev1.efternamn = "Nik";
            elev1.födelseDatum = new DateTime(2006, 12, 01);
            elev1.längd = 1.80;
            elev1.vikt = 85;

            Elev elev2 = new Elev();
            elev2.förnamn = "Sanchir";
            elev2.efternamn = "Tumentsetseg";
            elev2.födelseDatum = new DateTime(2004, 01, 26);
        }
    }
}
