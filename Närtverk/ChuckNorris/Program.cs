using System;
using System.Net;
using System.Text.Json;

namespace ChuckNorris
{
    // Mallen för att hämta data från JSON
    class Skämt
    {
        public string created_at {get; set;}
        public string icon_url {get; set;}
        public string value {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta en skämt från Chucknorris.io");

            // Url:en
            string url = "https://api.chucknorris.io/jokes/random";

            // Steg 1: hämta skämtet
            WebClient klient = new WebClient();
            string json = klient.DownloadString(url);

            // Skriv ut skämtet
            //Console.WriteLine(json);

            // Steg 2: Avkoda JSON
            // Skapa ett tomt objekt som skall fyllas
            Skämt objekt = new Skämt();
            objekt = JsonSerializer.Deserialize<Skämt>(json);

            // Steg 3: skriv ut skämtet
            Console.WriteLine(objekt.value);
            // Skriv ut bildadressen
            Console.WriteLine(objekt.icon_url);
            // Skriv ut skapde datum (created_at)
            Console.WriteLine(objekt.created_at);
        }
    }
}
