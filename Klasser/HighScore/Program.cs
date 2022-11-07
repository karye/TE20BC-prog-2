using System;
using System.Text.Json;
using System.IO;

namespace HighScore
{
    class Score
    {
        public string Namn {get; set;}
        public int Poäng {get; set;}
        public DateTime Datum {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HighScore!");

            // Använda klassen Score
            // Skapa mha "new"
            Score spelare1 = new Score();
            spelare1.namn = "Axel";
            spelare1.poäng = 150;
            spelare1.datum = new DateTime(2022, 11, 07); // Datetime.Now

            // Spara ned i textfil
            // - Omvandla till JSON-format
            // - Skriva JSON till textfil
            string jsonText = JsonSerializer.Serialize(spelare1);
            File.WriteAllText("score.json", jsonText);
            Console.WriteLine("Dina poäng är sparade!");
        }
    }
}
