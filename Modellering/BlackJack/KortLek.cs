/* 
Här har vi alla 52 kort
 */

using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class KortLek
    {
        // Samling av alla kort i leken
        private List<Kort> _korten;

        // Konstruktor
        public KortLek()
        {
            _korten = new List<Kort>();
        }

        // Fylla kortleken med alla 52 kort
        public void SkapaKortLek()
        {
            for (int i = 1; i < 14; i++)
            {
                // Skapa kort med färgen Hjärter
                Kort kortet = new Kort(Färgtyp.Hjärter, i);

                // Lägg till kortet i kortleken
                _korten.Add(kortet);

                // Skapa kort med färgen Hjärter
                kortet = new Kort(Färgtyp.Ruter, i);

                // Lägg till kortet i kortleken
                _korten.Add(kortet);
 
                // Skapa kort med färgen Hjärter
                kortet = new Kort(Färgtyp.Spader, i);

                // Lägg till kortet i kortleken
                _korten.Add(kortet);

                // Skapa kort med färgen Hjärter
                // Lägg till kortet i kortleken
                _korten.Add(new Kort(Färgtyp.Klöver, i));
            }
        }

        // Blanda kortleken
        public void BlandaKortlek()
        {
            // Slumptalsgenerator
            Random generator = new Random();

            // Flytta ett kort 52 ggr
            for (int i = 0; i < _korten.Count; i++)
            {
                // Slumpa ett kort från högen (0, 51)
                int index = generator.Next(0, _korten.Count);

                // Plocka ut ett kort ur högen
                Kort kortTemporär = _korten[i];

                // Lägg dit ett slumpat kort i den tomma platsen
                _korten[i] = _korten[index];

                // Tills slut lägg tillbaka det första kortet
                _korten[index] = kortTemporär;
            }
        }

        // EN metod som skan ge ut kortleken
        public List<Kort> GeKortlek()
        {
            return _korten;
        }
    }
}