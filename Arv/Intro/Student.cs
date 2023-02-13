using System;

namespace Intro
{
    public class Student : Person
    {
        public string årskull;

        public override void SkrivInfo()
        {
            Console.WriteLine($"Namn: {namn}, mobil: {mobil}, årskull: {årskull}");
        }
    }
}