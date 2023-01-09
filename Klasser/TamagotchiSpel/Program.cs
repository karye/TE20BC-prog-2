using System;

namespace TamagotchiSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TamagotchiSpel!");

            // Låt användaren döpa sin tamagotchi.
            Console.Write("Give the Tamagotchi a name? ");
            string name = Console.ReadLine();
            
            // Skapa (new) en tamagotchi
            Tamagotchi tama = new Tamagotchi(name);

            // Spelloop
            while (true)
            {
                // Skapa en meny
                Console.WriteLine("1. Teach a word");
                Console.WriteLine("2. Say Hi");
                Console.WriteLine("3. Feed it");
                Console.WriteLine("4. Nothing");
                Console.Write("What do you want to do? ");
                string choice = Console.ReadLine();

                // Låt spelaren välja mellan att lära tamagotchin ett nytt ord, hälsa på den, mata den eller göra ingenting.
                switch (choice)
                {
                    case "1":
                        Console.Write("Give me a word: ");
                        string word = Console.ReadLine();
                        tama.Teach(word);
                    break;

                    case "2":
                        tama.Hi();
                    break;

                    case "3":
                        tama.Feed();
                    break;

                    case "4":
                        tama.Tick();
                    break;
                    
                    default:
                    break;
                }

                tama.PrintStats();

                

            }
        }
    }
}
