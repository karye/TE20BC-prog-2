using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Black Jack!");

            // Två kort till Ashkan
            // Spader Kung & Ess
            Kort spaderKung = new Kort(Färgtyp.Spader, 13);
            Kort spaderEss = new Kort(Färgtyp.Spader, 1);

            // Ashkans hand är tom
            List<Kort> handAshkan = new List<Kort>();

            // Fyll handen med dessa två kort
            handAshkan.Add(spaderEss);
            handAshkan.Add(spaderKung);

            // Skriver ut handen
            // Loopa igenom listan handAshkan
            // Och skriv ut korten så att användaren förstår
            foreach (var kort in handAshkan)
            {
                Console.WriteLine(kort.TillText());
            }
        }
    }
}
