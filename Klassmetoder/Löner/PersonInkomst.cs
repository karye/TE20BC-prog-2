using System;

namespace Löner
{
    public class PersonInkomst
    {
        public string namn;
        public int timmar;
        public int timlön;

        // En metod för att räkna ut lönen
        public int Lönen()
        {
            return timlön * timmar;
        }
    }
}