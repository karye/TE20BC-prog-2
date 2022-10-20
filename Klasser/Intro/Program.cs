using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut lönen!");

            // Person1
            // Ange ditt namn
            Console.Write("Ange ditt namn: ");
            string namn1 = Console.ReadLine();
            
            // Timlön?
            Console.Write("Ange din timlön: ");
            int timlön1 = int.Parse(Console.ReadLine());

            // Antal timmar
            Console.Write("Ange antal timmar du jobbat: ");
            int antalTimmar1 = int.Parse(Console.ReadLine());

            // Svaret
            Console.WriteLine($"{namn1} din totala lön blir {timlön1 * antalTimmar1}");

            // Person2
            // Ange ditt namn
            Console.Write("Ange ditt namn: ");
            string namn2 = Console.ReadLine();
            
            // Timlön?
            Console.Write("Ange din timlön: ");
            int timlön2 = int.Parse(Console.ReadLine());

            // Antal timmar
            Console.Write("Ange antal timmar du jobbat: ");
            int antalTimmar2 = int.Parse(Console.ReadLine());

            // Svaret
            Console.WriteLine($"{namn2} din totala lön blir {timlön2 * antalTimmar2}");

            // Person3
            // Ange ditt namn
            Console.Write("Ange ditt namn: ");
            string namn3 = Console.ReadLine();
            
            // Timlön?
            Console.Write("Ange din timlön: ");
            int timlön3 = int.Parse(Console.ReadLine());

            // Antal timmar
            Console.Write("Ange antal timmar du jobbat: ");
            int antalTimmar3 = int.Parse(Console.ReadLine());

            // Svaret
            Console.WriteLine($"{namn3} din totala lön blir {timlön3 * antalTimmar3}");
        }
    }
}
