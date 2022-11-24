using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registrera boklån!");

            // EN lista för att samla all lån
            List<Boklån> listaLån = new List<Boklån>();

            // Del 1: registrera flera lån
            // Registreringsloop
            while (true)
            {
                // Skapar ett Boklån-objekt
                Boklån lån = new Boklån();

                // Vad heter boken & låntagaren
                Console.Write("Ange bok: ");
                lån.bok = Console.ReadLine();

                Console.Write("Ange låntagare: ");
                lån.låntagare = Console.ReadLine();
                
                lån.datum = DateTime.Now;

                // Lägg till i listan
                listaLån.Add(lån);
                
                // Avslut
                Console.Write("Vill du registrera ett till lån? (j/n)");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
            }

            // Del 2: Skriva ut alla lån med info när lånen går ut
            Console.WriteLine($"Antal lånade böcker {listaLån.Count}");
            foreach (var lån in listaLån)
            {
                lån.SkrivUt();
            }
        }
    }
}
