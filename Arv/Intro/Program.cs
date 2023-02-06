using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv intro");

            // Registrera en person
            Person person1 = new Person();
            person1.namn = "AAryan";
            person1.mobil = "0707868760";
            person1.SkrivInfo();

            // Registrera en student
            Student student1 = new Student();
            student1.namn = "Oskar";
            student1.mobil = "0707868768";
            student1.SkrivInfo();
            student1.SkrivInfoStudent();

            // Registrera en lärare
            Lärare lärare1 = new Lärare();
            lärare1.namn = "Karim";
            lärare1.mobil = "070787987";
            lärare1.SkrivInfo();
            lärare1.SkrivInfoLärare();
            
        }
    }
}
