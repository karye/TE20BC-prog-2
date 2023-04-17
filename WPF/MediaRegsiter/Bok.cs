using System;

namespace MediaRegister
{
    // Klassen beskriver en bok
    public class Bok : Media
    {
        // Interna variabler
        public string _författare;
        public string _antalSidor;

        // Metoder
        public Bok(string titel, string författare, string antalSidor)
        {
            _titel = titel;
            _författare = författare;
            _antalSidor = antalSidor;
        }

        public override string TillText()
        {
            return $"{_titel} - {_författare} ({_antalSidor}))";
        }
    }
}