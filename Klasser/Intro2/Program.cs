using System;

namespace Intro2
{
    // Mall
    class Person
    {
        public string namn;
        public int timlön;
        public int antalTimmar;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut löner!");

            // Person1
            Person person1 = new Person();  // Instansierar objektet/instans 
            Person person2 = new Person();
            Person person3 = new Person();

            Console.Write("Ange ditt namn: ");
            person1.namn = Console.ReadLine();

            Console.Write("Ange din timlön: ");
            person1.timlön = int.Parse(Console.ReadLine());

            Console.Write("Ange antal timmar: ");
            person1.antalTimmar = int.Parse(Console.ReadLine());
        }
    }
}
