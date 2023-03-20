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
           foreach (var kort in  kortlek.GeKortlek())
           {
                Console.WriteLine(kort.TillText());
           }
        }
    }
}
