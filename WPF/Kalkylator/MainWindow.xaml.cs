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

namespace Kalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int antalKlick = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Metod för att hantera klick på +
        private void KnappPlus(object sender, RoutedEventArgs e)
        {
            // Läs in tal1 & tal2
            double tal1 = double.Parse(rutaTal1.Text);
            double tal2 = double.Parse(rutaTal2.Text);

            // Skriv resultatet, dvs tal1 + tal2
            rutaResultat.Text = (tal1 + tal2).ToString();

            rutaAntalKlick.Text = (antalKlick++).ToString();
        }

        private void KnappMinus(object sender, RoutedEventArgs e)
        {
            // Läs in tal1 & tal2
            double tal1 = double.Parse(rutaTal1.Text);
            double tal2 = double.Parse(rutaTal2.Text);

            // Skriv resultatet, dvs tal1 + tal2
            rutaResultat.Text = (tal1 + tal2).ToString();

            rutaAntalKlick.Text = (antalKlick++).ToString();
        }
    }
}
