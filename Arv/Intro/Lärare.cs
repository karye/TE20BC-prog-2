using System;

namespace Intro
{
    public class Lärare : Person
    {
        public string anställningÅr;

        public override void SkrivInfo()
        {
            Console.WriteLine($"Namn: {namn}, mobil: {mobil}, anställningÅr: {anställningÅr}");
        }
    }
}