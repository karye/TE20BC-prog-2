using System;
using System.Windows;
using System.IO;
using System.Timers;

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
            Timer timer = new Timer(1000);
            timer.Elapsed += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object source, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(UpdateraKlocka);
        }

        private void UpdateraKlocka()
        {
            DateTime nu = DateTime.Now;
            rutaKlocka.Text = nu.ToString("HH:mm:ss");
        }

        // Hantera klick på knappen Frivarv
        private void KlickFrivarv(object sender, RoutedEventArgs e)
        {
            // Räkna upp poängen för innelaget
            innePoäng += 5;

            // Skriv innelaget poäng
            rutaInne.Text = innePoäng.ToString();

            // Skriv ut i rutan historik
            DateTime nu = DateTime.Now;
            rutaHistorik.Text += nu.ToString("HH:mm:ss") + " Frivarv +5 poäng\n";

            // Spara ned i en textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }

        // Hantera klick på knappen Frivarv
        private void KlickBränning(object sender, RoutedEventArgs e)
        {
            utePoäng += 2;
            rutaUte.Text = utePoäng.ToString();

            // Skriv ut i rutan historik
            DateTime nu = DateTime.Now;
            rutaHistorik.Text += nu.ToString("HH:mm:ss") + " Bränning +2 poäng\n";

            // Spara ned i en textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }

        // Hantera klick på knappen Frivarv
        private void KlickLyra(object sender, RoutedEventArgs e)
        {
            utePoäng += 3;
            rutaUte.Text = utePoäng.ToString();

            // Skriv ut i rutan historik
            DateTime nu = DateTime.Now;
            rutaHistorik.Text += nu.ToString("HH:mm:ss") + " Lyra +3 poäng\n";

            // Spara ned i en textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }

        // Hantera klick på knappen Frivarv
        private void KlickVarv(object sender, RoutedEventArgs e)
        {
            innePoäng += 1;
            rutaInne.Text = innePoäng.ToString();

            // Skriv ut i rutan historik
            DateTime nu = DateTime.Now;
            rutaHistorik.Text += nu.ToString("HH:mm:ss") + " Varv +1 poäng\n";

            // Spara ned i en textfil
            File.WriteAllText("historik.txt", rutaHistorik.Text);
        }
    }
}
