using System;

namespace BlackJack
{
    public class Dealer : Spelare
    {
        public Dealer(string n) : base (n)
        {
            
        }

        // Dealer räknar Ess som 11 alltid
        public override int Poäng()
        {
            int poäng = 0;
            foreach (var kort in Hand())
            {
                if (kort.BlackJackVärde() == 11 && poäng + 11 > 21)
                {
                    poäng += 1;
                }
                else
                {
                    poäng += kort.BlackJackVärde();
                }
            }

            return poäng;
        }
    }
}