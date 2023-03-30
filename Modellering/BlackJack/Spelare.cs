using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Spelare
    {
        // Interna variabler
        private string _namn;
        private List<Kort> _hand;

        // Metoderna
        // Konstruktor (ctor)
        public Spelare(string namn)
        {
            _namn = namn;
            _hand = new List<Kort>();
        }

        // Metod för ta emot ett kort och
        // spara den i "handen"
        public void TaEmotKort(Kort kortet)
        {
            _hand.Add(kortet);
        }

        // Metod för att räkna ihop totala
        // BlackJack-poängen för alla kort i "handen"
        public virtual int Poäng()
        {
            int summaPoäng = 0;
            foreach (var kort in _hand)
            {
                summaPoäng += kort.BlackJackVärde();
            }
            return summaPoäng;
        }

        // Metod för lista alla kort i "handen"
        public List<Kort> Hand()
        {
            return _hand;
        }
    }
}