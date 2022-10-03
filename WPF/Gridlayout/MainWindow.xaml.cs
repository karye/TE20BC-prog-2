using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;

namespace Gridlayout
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

        // Hantera "event" Click på knappen Skicka!
        private void KlickSkicka(object sender, RoutedEventArgs e)
        {
            // Läs av inputrutorna
            string epost = rutaEpost.Text;
            string texten = rutaTexten.Text;

            // 1:a kontrollen - inte tomt
            if (epost == "" || texten == "")
            {
                rutaStatus.Text = "Fel! Epost eller text saknas";
            }
            else
            {
                // 2:a kontrollen - epost rätt format?
                Regex regexEpost = new Regex("\\S+@\\S+\\.\\S+");
                if (!regexEpost.IsMatch(epost))
                {
                    rutaStatus.Text = "Fel! Epost ogiltigt format";
                }
                else
                {
                    rutaStatus.Text = "Epost skickad";
                }
            }
        }
    }
}
