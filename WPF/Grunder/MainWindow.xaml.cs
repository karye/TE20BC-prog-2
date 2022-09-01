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

namespace Grunder
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

        // Fånga upp "event" ClickKnappOk
        private void ClickKnappOk(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Klickade på knappen OK");
            textruta.Text += "Klickade på knappen OK\n";
        }

        // Fånga upp "event" ClickKnappAvbryt
        private void ClickKnappAvbryt(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Klickade på knappen Avbryt");
            textruta.Text += "Klickade på knappen Avbryt\n";
        }
    }
}
