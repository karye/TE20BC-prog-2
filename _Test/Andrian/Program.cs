using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace highscore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spara spelares poäng");

            List<SpelarePoäng> spelareLista = SpelarePoäng.LäsInPoäng();

            // Skapa en spelare
            SpelarePoäng spelare1 = new SpelarePoäng("Lars", 100, DateTime.Now);
            spelareLista.Add(spelare1);

            // Skapa en spelare
            SpelarePoäng spelare2 = new SpelarePoäng("Filip", 50, DateTime.Now);
            spelareLista.Add(spelare2);

            SpelarePoäng.SparaPoäng(spelareLista); 
        }
    }

    class SpelarePoäng
    {
        public string Namn { get; set; }
        public int Poang { get; set; }
        public DateTime Datum { get; set; }
        
        static string filNamn = "highscore.json";

        public SpelarePoäng(string namn, int poäng, DateTime datum)
        {
            Namn = namn;
            Poang = poäng;
            Datum = datum;
        }

        public static List<SpelarePoäng> LäsInPoäng()
        {
            if(File.Exists(filNamn))
            {
                string jsonIn = File.ReadAllText(filNamn);

                return JsonSerializer.Deserialize<List<SpelarePoäng>>(jsonIn);
            }
            else
            {
                return new List<SpelarePoäng>();
            }
        }

        public static void SparaPoäng(List<SpelarePoäng> spelarePoäng)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(spelarePoäng, options);

            File.WriteAllText(filNamn, json);
        }
    }
}