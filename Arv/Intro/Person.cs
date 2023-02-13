using System;

namespace Intro
{
    public class Person
    {
        public string namn;
        public string mobil;

        public virtual void SkrivInfo()
        {
            Console.WriteLine($"Namn: {namn}, mobil: {mobil}");
        }
    }
}