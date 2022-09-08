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

namespace Labb2
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

        // Hantera klick på knappen SLumpa!
        private void KlickSlumpa(object sender, RoutedEventArgs e)
        {
            // Slumpa fram ett tal 
            Random generator = new Random();
            int slumptal = generator.Next(1, 101);

            rutaResultat.Text = slumptal.ToString(); // $"{slumptal}"
        }
    }
}
