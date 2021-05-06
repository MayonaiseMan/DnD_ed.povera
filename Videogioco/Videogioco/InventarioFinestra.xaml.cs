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
    /// Logica di interazione per InventarioFinestra.xaml
    /// </summary>
    public partial class InventarioFinestra : Window
    {

        StatistichePersonaggio _mainStatistiche;
        negozio _mainNegozio;

        public InventarioFinestra()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainStatistiche = new StatistichePersonaggio();
            _mainStatistiche.Show();
            this.Close();
        }

        private void btnAcquista_Click(object sender, RoutedEventArgs e)
        {
            _mainNegozio = new negozio();
            _mainNegozio.Show();
            this.Close();
        }
    }
}
