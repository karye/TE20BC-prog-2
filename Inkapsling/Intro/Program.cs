using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Använder klassen för att samla lite data
            PersonInkomst personInkomst = new PersonInkomst();

            // 3 interna variabler
            //personInkomst._namn = "Alex";
            //personInkomst._inkomst = 10000;
            //personInkomst._timmar = 100;

            // Klassens egenskaper

            personInkomst.Namn = "Alex";
            personInkomst.Inkomst = 10000;
            personInkomst.Timmar = 100;

            PersonData personData = new PersonData();
        }
    }
}
