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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool spelareTur = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Hantera klick på knapparna
        private void KlickKnapp(object sender, RoutedEventArgs e)
        {
            // Vad heter knappen?
            Button knapp = (Button)sender;
            knapp.FontSize = 90;
            knapp.IsEnabled = false;

            // Varannans tur
            if (spelareTur)
            {
                // Spelare 1 klickar
                knapp.Content = "X";
                spelareTur = false;
            }
            else
            {
                // Spelare 2 klickar 
                knapp.Content = "O";
                spelareTur = true;
            }

            // Är en rad fylld X?
            if (knapp1.Content == "X" && knapp2.Content == "X" && knapp3.Content == "X" || 
                knapp4.Content == "X" && knapp5.Content == "X" && knapp6.Content == "X" || 
                knapp7.Content == "X" && knapp8.Content == "X" && knapp9.Content == "X")
            {
                MessageBox.Show("Spelare 1 har vunnit!");
                Omstart();
            }

            // Är en rad fylld O?
            if (knapp1.Content == "O" && knapp2.Content == "O" && knapp3.Content == "O" || 
                knapp4.Content == "O" && knapp5.Content == "O" && knapp6.Content == "O" || 
                knapp7.Content == "O" && knapp8.Content == "O" && knapp9.Content == "O")
            {
                MessageBox.Show("Spelare 2 har vunnit!");
                Omstart();
            }

            // Är en kolumn fylld X?
            if (knapp1.Content == "X" && knapp4.Content == "X" && knapp7.Content == "X" || 
                knapp2.Content == "X" && knapp5.Content == "X" && knapp8.Content == "X" || 
                knapp3.Content == "X" && knapp6.Content == "X" && knapp9.Content == "X")
            {
                MessageBox.Show("Spelare 1 har vunnit!");
                Omstart();
            }

            // Är en kolumn fylld O?
            if (knapp1.Content == "O" && knapp4.Content == "O" && knapp7.Content == "O" || 
                knapp2.Content == "O" && knapp5.Content == "O" && knapp8.Content == "O" || 
                knapp3.Content == "O" && knapp6.Content == "O" && knapp9.Content == "O")
            {
                MessageBox.Show("Spelare 2 har vunnit!");
                Omstart();
            }

            // Är en diagonal fylld X?
            if (knapp1.Content == "X" && knapp5.Content == "X" && knapp9.Content == "X" || 
                knapp3.Content == "X" && knapp5.Content == "X" && knapp7.Content == "X")
            {
                MessageBox.Show("Spelare 1 har vunnit!");
                Omstart();
            }

            // Är en diagonal fylld O?
            if (knapp1.Content == "O" && knapp5.Content == "O" && knapp9.Content == "O" || 
                knapp3.Content == "O" && knapp5.Content == "O" && knapp7.Content == "O")
            {
                MessageBox.Show("Spelare 2 har vunnit!");
                Omstart();
            }

            // Är det oavgjort?
            if (knapp1.Content != null && knapp4.Content != null && knapp7.Content != null && 
                knapp2.Content != null && knapp5.Content != null && knapp8.Content != null && 
                knapp3.Content != null && knapp6.Content != null && knapp9.Content != null)
            {
                MessageBox.Show("Oavgjort! Spelet bröjar om!");
                Omstart();
            }
        }

        private void Omstart()
        {
            knapp1.Content = null;
            knapp1.IsEnabled = true;
            knapp2.Content = null;
            knapp2.IsEnabled = true;
            knapp3.Content = null;
            knapp3.IsEnabled = true;
            knapp4.Content = null;
            knapp4.IsEnabled = true;
            knapp5.Content = null;
            knapp5.IsEnabled = true;
            knapp6.Content = null;
            knapp6.IsEnabled = true;
            knapp7.Content = null;
            knapp7.IsEnabled = true;
            knapp8.Content = null;
            knapp8.IsEnabled = true;
            knapp9.Content = null;
            knapp9.IsEnabled = true;
        }
    }
}
