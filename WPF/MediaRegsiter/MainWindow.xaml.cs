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
        // Nyttjar polymorphism, dvs Media kan hantera både Bok och Film
        List<Media> register = new List<Media>();

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

            // Steg 4 - spara i listan
            register.Add(film);
        }

        // Hantera Spara Bok
        private void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            Bok bok = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text);
            rutaResultat.Items.Add(bok.TillText());

            register.Add(bok);
        }

        // Hantera klick på radioknapp
        private void CheckRadio(object sender, RoutedEventArgs e)
        {
            // Rensar listboxen i gränssnitt
            rutaResultat.Items.Clear();

            // Vilken radioknapp har tryckts på? (allt, böcker, filmer)
            string typ = ((RadioButton)sender).Name;

            // Beroende på typ
            switch (typ)
            {
                case "allt":
                    // Skriv ut allt registret (radioknappen Allt)
                    foreach (var media in register)
                    {
                        rutaResultat.Items.Add(media.TillText());
                    }
                    break;
                case "böcker":
                    foreach (var media in register)
                    {
                        // Plocka bara ut böcker
                        if (media is Bok)       // is kollar namnet på klassen
                        {
                            rutaResultat.Items.Add(media.TillText());
                        }
                    }
                    break;
                case "filmer":
                    foreach (var media in register)
                    {
                        // Plocka bara ut filmer
                        if (media is Film)
                        {
                            rutaResultat.Items.Add(media.TillText());
                        }
                    }
                    break;
            }
        }
    }
}
