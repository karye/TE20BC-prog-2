using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Black Jack!");

            // Skapa en spelare med ett namn
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();
            Spelare spelare1 = new Spelare(namn);

            // Skapa en dealer
            Dealer dealer = new Dealer("Dealer");

            // Skapa en kortlek med 52 kort
            KortLek kortlek = new KortLek();
            kortlek.SkapaKortLek();

            // Blanda kortleken
            kortlek.BlandaKortlek();

            // Spelomgång börjar (spelloopen)
            string spelStatus = "spelar";
            while (spelStatus == "spelar")
            {
                // Ge två kort till spelaren
                // Alt 1: skapa ett kort, sen ge kortet
                Kort ettKort = kortlek.DraKort();
                spelare1.TaEmotKort(ettKort);
                // Alt 2: ge kortet direkt
                spelare1.TaEmotKort(kortlek.DraKort());
                // Spelaren har nu 2 kort i handen

                // .. och två kort till dealern
                dealer.TaEmotKort(kortlek.DraKort());
                dealer.TaEmotKort(kortlek.DraKort());

                // Visa spelarens kort
                Console.Write("Dina två kort är: ");
                foreach (var kort in spelare1.Hand())
                {
                    Console.Write(kort.TillText() + ", ");
                }
                Console.WriteLine($"\nPoäng: {spelare1.Poäng()}");

                // Om dealern får 21 förlorar spelaren!
                if (dealer.Poäng() == 21)
                {
                    Console.WriteLine("Dealern har Black Jack och du har forlorat spelomgången!");
                    spelStatus = "förlorat";
                    break;
                }
                // Om spelaren får 21, vinner spelaren direkt.
                else if (spelare1.Poäng() == 21)
                {
                    Console.WriteLine("Du har Black Jack och du har vunnit spelomgången!");
                    spelStatus = "vunnit";
                    break;
                }

                // Visa dealerns första kort
                Console.WriteLine("Dealern kort är: " + dealer.Hand()[0].TillText());

                // Spelaren får välja att dra kort eller stanna. Om spelaren stannar, går turen vidare till dealern.
                while (true)
                {
                    Console.Write("Vill du dra ett kort till (j/n): ");
                    string val = Console.ReadLine();
                    if (val.ToLower() == "j")
                    {
                        spelare1.TaEmotKort(kortlek.DraKort());
                        Console.Write("Dina kort är: ");
                        foreach (var kort in spelare1.Hand())
                        {
                            Console.Write(kort.TillText() + ", ");
                        }
                        Console.WriteLine($"\nPoäng: {spelare1.Poäng()}");

                        // Om spelare får över 21 förlorar hen
                        if (spelare1.Poäng() > 21)
                        {
                            Console.WriteLine("Du förlorar!");
                            spelStatus = "förlorat";
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                // Spelaren har förlorat
                if (spelStatus == "förlorat" || spelStatus == "vunnit")
                {
                    break;
                }

                // Dealern drar kort tills den når 17 eller över. 
                while (dealer.Poäng() < 17)
                {
                    // Dealern drar ett kort
                    dealer.TaEmotKort(kortlek.DraKort());
                }

                // Om dealern får 21, eller över och då förlorar spelaren direkt.
                if (dealer.Poäng() > 21)
                {
                    Console.WriteLine("Dealern har mer 21, du vann!");
                    spelStatus = "vunnit";
                    break;
                }

                // Om dealern får 21
                if (dealer.Poäng() == 21 && spelare1.Poäng() < 21)
                {
                    Console.WriteLine("Du förlorar!");
                    spelStatus = "förlorat";
                    break;
                }

                // Om dealer och spelaren har lika många poäng
                if (dealer.Poäng() == spelare1.Poäng())
                {
                    Console.WriteLine("Oavgjort!");
                    spelStatus = "oavgjort";
                    break;
                }
                // Vem har högst har vunnit!
                else if (dealer.Poäng() < spelare1.Poäng())
                {
                    Console.WriteLine("Du har högre poäng och vinner!");
                    spelStatus = "vunnit";
                    break;
                }
                else
                {
                    Console.WriteLine("Du har lägre poäng och förlorar!");
                    spelStatus = "förlorat";
                    break;
                }
            }

            // Spelet är slut!
        }
    }
}
