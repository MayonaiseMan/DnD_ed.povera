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
    /// Logica di interazione per StatistichePersonaggio.xaml
    /// </summary>
    public partial class StatistichePersonaggio : Window
    {

        Impostazione impostazioni;
        FinestraGioco _mainGioco;
        InventarioFinestra _mainInventario;
        MainWindow main;

        public StatistichePersonaggio()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainGioco = new FinestraGioco(main, impostazioni);
            _mainGioco.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _mainInventario = new InventarioFinestra();
            _mainInventario.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _mainInventario = new InventarioFinestra();
            _mainInventario.Show();
            this.Close();
        }
    }
}
