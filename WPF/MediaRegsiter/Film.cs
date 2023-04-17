using System;

namespace MediaRegister
{
    // Klassen beskriver en film
    public class Film : Media
    {
        // Interna variabler
        public string _regissör;
        public string _längd;

        // Metoder
        public override string TillText()
        {
            return $"{_titel} - {_regissör} ({_längd}))";
        }
    }
}