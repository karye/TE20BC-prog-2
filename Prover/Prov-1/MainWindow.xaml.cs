using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prov_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int slumptal;   // "global" variabel
        Random generator = new Random();
        int antal;

        public MainWindow()
        {
            InitializeComponent();

            // Stänga av Gissa-knappen
            knappGissa.IsEnabled = false;
        }

        // Hanterar klick på knappen Start
        private void KlickStart(object sender, RoutedEventArgs e)
        {
            // Slumpar ett tal
            slumptal = generator.Next(1, 101);  // 1-100

            // Räkna antalet gissningar
            antal = 0;

            // Stäng av Start-knappen
            knappStarta.IsEnabled = false;

            // Sätt på Gissa-knappen
            knappGissa.IsEnabled = true;
        }

        // Hanterar klick på knappen Gissa
        private void KlickGissa(object sender, RoutedEventArgs e)
        {
            // Läs in gissning som användaren skrivit
            int gissning = int.Parse(rutaGissning.Text);

            // Räkna upp antal försök
            antal++;

            // Fler än 10 försök?
            if (antal > 10)
            {
                rutaSvar.Text += "Du förlorade!\n";    // Den 11:e gången eller mer

                // Sätt på Start-knappen
                knappStarta.IsEnabled = true;

                // Stäng av Gissa-knappen
                knappGissa.IsEnabled = true;
            }
            else
            {
                // Kolla om gissning är rätt
                if (gissning == slumptal)
                {
                    rutaSvar.Text += "Rätt gissat!\n";

                    // Sätt på Start-knappen
                    knappStarta.IsEnabled = true;

                    // Stäng av Gissa-knappen
                    knappGissa.IsEnabled = true;
                }
                else if (gissning > slumptal)
                {
                    rutaSvar.Text += "För högt!\n";
                }
                else
                {
                    rutaSvar.Text += "För lågt!\n";
                }
            }
        }
    }
}
