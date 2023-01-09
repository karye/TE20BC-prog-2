using System;
using System.Collections.Generic;

namespace TamagotchiSpel
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random generator = new Random();
        public string name = "";

        // Sätta startvärden (konstruktorn ctor)
        public Tamagotchi(string newName)
        {
            name = newName;
        }

        // Feed() sänker Hunger
        public void Feed()
        {
            if (hunger > 0)
            {
                hunger--;
            }
        }

        // Hi() skriver ut ett slumpat ord från words, och anropar ReduceBoredom()
        public void Hi()
        {
            if (words.Count == 0)
            {
                Console.WriteLine("Sorry, don't know any words!");
            }
            else
            {
                int index = generator.Next(0, words.Count);
                Console.WriteLine(words[index]);
                ReduceBoredom();
            }
        }

        // Teach(string word) lägger till ett ord i words, och anropar ReduceBoredom().
        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        // Tick() ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

        // PrintStats() skriver ut nuvarande hunger och boredom, och meddelar också huruvida tamagotchin lever.
        public void PrintStats()
        {
            Console.WriteLine($"Hunger: {hunger}, Boredom: {boredom}");
            if (isAlive)
            {
                Console.WriteLine("Tamagotchi is alive!");
            }
            else
            {
                Console.WriteLine("Tamagotchi i dead!");
            }
        }

        // GetAlive() returnerar värdet som isAlive har.
        public bool GetAlive()
        {
            return isAlive;
        }

        // ReduceBoredom() sänker boredom.
        private void ReduceBoredom()
        {
            if (boredom > 0)
            {
                boredom--;
            }
        }
    }
}