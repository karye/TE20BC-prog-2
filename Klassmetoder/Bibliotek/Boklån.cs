using System;

namespace Bibliotek
{
    public class Boklån
    {
        public string bok;
        public string låntagare;
        public DateTime datum;

        // När låneperioden går ut
        public DateTime LämnasTillbaka()
        {
            return datum.AddDays(30);
        }

        // Dagar kvar av lånet
        public int DagarKvar()
        {
            return (int)(LämnasTillbaka() - DateTime.Now).TotalDays;
        }

        // Skriv info om lånet
        public void SkrivUt()
        {
            Console.WriteLine($"- {bok} lånad av {låntagare}, lämnas tillbaka {LämnasTillbaka()} dvs {DagarKvar()} dagar kvar");
        }

        // Flörläng lånet med 30 dagar
        public void FörlängLån()
        {
            datum = datum.AddDays(30);
        }
    }
}