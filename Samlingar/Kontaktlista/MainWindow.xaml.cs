using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace kontaktlista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Interna kontaktlistan
        //static string[] listan = new string[100];
        static List<string> listan = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Hantera klick på knappen 
        private void KlickLäggTill(object sender, RoutedEventArgs e)
        {
            // Läs av namn & mobil
            string namn = rutaNamn.Text;
            string mobil = rutaMobil.Text;

            // Om namn och mobil ej tomma 
            // Skriv ut i listrutan
            // annars skriv ut felmeddelande
            if (namn == "" || mobil == "")
            {
                rutaStatus.Text = "Fel! Vg. ange namn och mobil";
            }
            else
            {
                //rutaLista.Text += $"{namn}\t{mobil}\n";
                rutaLista.Text += namn + "\t" + mobil + "\n";

                // Lägg till kontakten i listan
                listan.Add(namn + "\t" + mobil);

                // Spara ned i en textfil
                File.WriteAllLines("kontakter.txt", listan);
            }
        }
    }
}
