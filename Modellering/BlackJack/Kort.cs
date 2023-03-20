using System;

namespace BlackJack
{
    public enum Färgtyp
    {
        Hjärter, Ruter, Spader, Klöver
    }
    public class Kort
    {
        // Interna variabler
        // Värdet på kortet 1-10, 11, 12, 13
        private int _värde;
        // Färgen på kortet; Hjärter, Ruter, Spader, Klöver
        private Färgtyp _färg;

        // Metoder
        // Konstruktor
        public Kort(Färgtyp färg, int värde)
        {
            _värde = värde;
            _färg = färg;
        }

        // Få ut kortets värde och färg i text (svenska)
        // Få ut i texten: 
        // 11 = knekt, 12 = dam, 13 = kung, 1 = Ess
        public string TillText()
        {
            string textenFärg = _färg.ToString() + " ";

            switch (_värde)
            {
                case 1:
                    return textenFärg + "ess";

                case 11:
                    return textenFärg + "knekt";

                case 12:
                    return textenFärg + "dam";

                case 13:
                    return textenFärg + "kung";

                default:
                    return textenFärg + _värde;

            }
        }

        // Räkna ut BlackJack värdet
        public int BlackJackVärde()
        {
            switch (_värde)
            {
                case 1:
                    return 1;   // @TODO Ess kan vara 11 också!
                case 11:
                    return 10;
                case 12:
                    return 10;
                case 13:
                    return 10;
                default:
                    return _värde;
            }
        }
    }
}