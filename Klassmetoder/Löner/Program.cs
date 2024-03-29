﻿using System;
using System.Collections.Generic;

namespace Löner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello löner!");

            // Spara alla anställda och data
            List<PersonInkomst> listaAnställda = new List<PersonInkomst>();

            // Loop för att mata in varje anställd: namn, timmar, timlön
            while (true)
            {
                Console.Write("Ange namn: ");
                string namn = Console.ReadLine();
                Console.Write("Ange antal timmar: ");
                int timmar = int.Parse(Console.ReadLine());
                Console.Write("Ange timlön: ");
                int timlön = int.Parse(Console.ReadLine());

                PersonInkomst anställd = new PersonInkomst(namn, timmar, timlön);

                // Spara i listan
                listaAnställda.Add(anställd);
                
                // Fler?
                Console.Write("Vill du mata in en till? (j/n)");
                string svar = Console.ReadLine();
                if (svar == "n")
                    break;
            }

            // Skriv ut alla anställda och deras lön
            // Avsluta med totala lönen
            int totalLön = 0;
            foreach (var anställd in listaAnställda)
            {
                Console.WriteLine($"{anställd.namn} har lönen {anställd.Lönen()}");
                totalLön += anställd.Lönen();
            }
            Console.WriteLine($"Totala lönekostnader är {totalLön}");
        }
    }
}
