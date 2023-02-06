using System;

namespace Intro
{
    public class Lärare : Person
    {
        public string anställningÅr;

        public void SkrivInfoLärare()
        {
            Console.WriteLine($"Namn: {namn}, mobil: {mobil}, anställningÅr: {anställningÅr}");
        }
    }
}