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

namespace MediaRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Metoder för alla events från gränssnittet
        // Hantera Spara film
        private void KlickSparaFilm(object sender, RoutedEventArgs e)
        {
            // Steg 1 - läs in från textrutorna
            string titel = rutaFilmtitel.Text;
            string regissör = rutaRegissör.Text;
            string längd = rutaLängd.Text;

            // Steg 2 - spara i ett objekt (instans)
            Film film = new Film();
            film._titel = titel;
            film._regissör = regissör;
            film._längd = längd;

            // Steg 3 - skriv ut listan
            rutaResultat.Items.Add(film.TillText());
        }

        // Hantera Spara Bok
        private void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            Bok bok = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text);
            rutaResultat.Items.Add(bok.TillText());

            //rutaResultat.Items.Add(new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text).TillText());
        }

        // Hantera klick på radioknapp
        private void CheckRadio(object sender, RoutedEventArgs e)
        {

        }
    }
}
