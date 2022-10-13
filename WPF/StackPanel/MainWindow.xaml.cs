using System.Windows;

namespace StackPanel
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

        private void KlickSkicka(object sender, RoutedEventArgs e)
        {
            if (rutaEpost.Text == "" || rutaTexten.Text == "")
            {
                rutaStatus.Text = "Fel! Vg fyll epost och text...";
            }
            else
            {
                rutaStatus.Text = "Meddelande har skickats!";
            }
        }
    }
}
