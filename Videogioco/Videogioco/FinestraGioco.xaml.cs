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
using System.Windows.Shapes;

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per FinestraGioco.xaml
    /// </summary>
    public partial class FinestraGioco : Window
    {
        Gioco gioco;
        MainWindow start;
        CreaPersonaggio _mainPersonaggio;
        StatistichePersonaggio _mainStatistiche;
        BattagliaFinestra _mainScontro;
        Personaggio personaggio1, personaggio2;      


        public FinestraGioco(MainWindow main, Impostazione i)
        {
            InitializeComponent();
            gioco = new Gioco();
            start = main;
            lstPersonaggi.ItemsSource = gioco.Personaggi;
            btnStatistiche.Visibility = Visibility.Hidden; //Prova
            btnCreaPersonaggio.Visibility = Visibility.Hidden; //Prova
        }

        private void btnCreaPersonaggio_Click(object sender, RoutedEventArgs e)
        {
            _mainPersonaggio = new CreaPersonaggio(this);
            _mainPersonaggio.Show();
            this.Close();
        }

        private void btnStatistiche_Click(object sender, RoutedEventArgs e)
        {
            _mainStatistiche = new StatistichePersonaggio();
            _mainStatistiche.Show();
            this.Close();
        }

        private void btnPaly_Click(object sender, RoutedEventArgs e)
        {
            _mainScontro = new BattagliaFinestra(personaggio1, personaggio2);
            _mainScontro.Show();
            this.Close();
            

        }

        private void lstPersonaggi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((string)lblPersonaggio1.Content == "Personaggio1")
            {
                personaggio1 = lstPersonaggi.SelectedItem as Personaggio;
                lblPersonaggio1.Content = lstPersonaggi.SelectedItem.ToString();
            }
            else
            {
                if ((string)lblPersonaggio2.Content == "Personaggio2")
                {
                    personaggio2 = lstPersonaggi.SelectedItem as Personaggio;
                    lblPersonaggio2.Content = lstPersonaggi.SelectedItem.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblPersonaggio1.Content = "Personaggio1";
            lblPersonaggio2.Content = "Personaggio2";
        }
    }
}
