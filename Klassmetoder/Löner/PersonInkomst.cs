using System;

namespace Löner
{
    public class PersonInkomst
    {
        public string namn;
        public int timmar;
        public int timlön;

        // Konstruktor
        public PersonInkomst(string n, int tm, int tl)
        {
            namn = n;
            timmar = tm;
            timlön = tl;
        }

        // En metod för att räkna ut lönen
        public int Lönen()
        {
            return timlön * timmar;
        }
    }
}