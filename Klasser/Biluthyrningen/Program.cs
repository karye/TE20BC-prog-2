using System;
using System.Collections.Generic;

namespace Biluthyrningen
{
    // "Paket" med info om uthyrning
    class InfoUthyrning
    {
        public string regnr;
        public string personnr;
        public DateTime datum;
        public string antalKm;
        public string kmPris;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");

            // För att lagra uthyrningar
            List<InfoUthyrning> listaUthyrningar = new List<InfoUthyrning>();

            // Programloop
            while (true)
            {
                // Skapa ett uthyrningsobjekt
                InfoUthyrning uthyrning = new InfoUthyrning();

                // Registrera en uthyrning
                Console.Write("Ange regnr: ");
                uthyrning.regnr = Console.ReadLine();
                Console.Write("Ange personnr: ");
                uthyrning.personnr = Console.ReadLine();
                Console.Write("Ange antal km: ");
                uthyrning.antalKm = Console.ReadLine();
                Console.Write("Ange kmpris: ");
                uthyrning.kmPris = Console.ReadLine();
                
                // Tiden
                uthyrning.datum = DateTime.Now;

                // Spara det uthyrningen
                listaUthyrningar.Add(uthyrning);

                Console.Write("Vill du registrera en till uthyrning (j/n)? ");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
            }

            // Beräkna kostnad
            Console.Write("Beräkna kostnad, ange regnr: ");
            string regnr = Console.ReadLine();
            
            // Hitta uthyrningen
            foreach (var enUthyrning in listaUthyrningar)
            {
                if (enUthyrning.regnr == regnr)
                {
                    //Console.WriteLine("Ange total antal km: ");
                    //enUthyrning.antalKm = Console.ReadLine();
                    
                    // Kostnaden blir
                    int kostnad = int.Parse(enUthyrning.antalKm) * int.Parse(enUthyrning.kmPris);
                    Console.WriteLine($"Kundens uthyrningskostnad blir {kostnad}");
                }
            }

        }
    }
}
