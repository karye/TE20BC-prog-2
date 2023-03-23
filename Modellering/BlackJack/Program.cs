using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Black Jack!");

            // Skriv ut alla kort i kortleken
            // Steg 1 Skapa ett objekt = kortlek
            KortLek kortlek = new KortLek();

            // Steg 2 - fyll med alla 52 kort
            kortlek.SkapaKortLek();

            // Steg 3 - blanda
            kortlek.BlandaKortlek();

            // Steg 4 
           /* foreach (var kort in  kortlek.GeKortlek())
           {
                Console.WriteLine(kort.TillText());
           } */

           // Testa att dra ett kort o skriv ut det
           Kort ettKort = kortlek.DraKort();
           Console.WriteLine(ettKort.TillText());

           // Skapa en spelare med ett namn
           Spelare spelare1 = new Spelare("Kalle");

           // Ge spelare1 det dragna kortet
           spelare1.TaEmotKort(ettKort);

           // Skriv spelare1 totala poäng
           Console.WriteLine(spelare1.Poäng());

           // Dra ett till kort och ge till spelare1
           ettKort = kortlek.DraKort();
           Console.WriteLine(ettKort.TillText());
           spelare1.TaEmotKort(ettKort);
           Console.WriteLine(spelare1.Poäng());

           
        }
    }
}
