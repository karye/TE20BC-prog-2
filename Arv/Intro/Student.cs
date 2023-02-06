using System;

namespace Intro
{
    public class Student : Person
    {
        public string årskull;

        public void SkrivInfoStudent()
        {
            Console.WriteLine($"Namn: {namn}, mobil: {mobil}, årskull: {årskull}");
        }
    }
}