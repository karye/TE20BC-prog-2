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

namespace BrannbollRaknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int innePoäng = 0;
        static int utePoäng = 0;

        // Programmet startar
        public MainWindow()
        {
            InitializeComponent();
        }

        // Hantera klick på knappen Frivarv
        private void KlickFrivarv(object sender, RoutedEventArgs e)
        {
            // Räkna upp poängen för innelaget
            innePoäng += 5;

            // Skriv innelaget poäng
            rutaInne.Text = innePoäng.ToString();
        }

        // Hantera klick på knappen Frivarv
        private void KlickBränning(object sender, RoutedEventArgs e)
        {
            utePoäng += 2;
            rutaUte.Text = "2";
        }

        // Hantera klick på knappen Frivarv
        private void KlickLyra(object sender, RoutedEventArgs e)
        {
            utePoäng += 3;
            rutaUte.Text = "3";
        }

        // Hantera klick på knappen Frivarv
        private void KlickVarv(object sender, RoutedEventArgs e)
        {
            innePoäng += 1;
            rutaInne.Text = "1";
        }
    }
}
