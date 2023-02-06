using System;

namespace Intro
{
    public class Person
    {
        public string namn;
        public string mobil;

        public void SkrivInfo()
        {
            Console.WriteLine($"Namn: {namn}, mobil: {mobil}");
        }
    }
}