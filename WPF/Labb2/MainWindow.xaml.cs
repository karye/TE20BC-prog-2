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
            // Läs in max
            string maxString = rutaMax.Text;
            int max = 0;
            int slumptal = 0;

            /* if (maxString == "")
            {
                max = 101;
            }
            else
            {
                max = int.Parse(maxString);
            } */

            if (!int.TryParse(maxString, out max))
            {
                max = 101;
            }
            
            // Slumpa fram ett tal 
            Random generator = new Random();
            slumptal = generator.Next(1, max);

            rutaResultat.Text = slumptal.ToString(); // $"{slumptal}"
        }
    }
}
