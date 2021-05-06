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
    /// Logica di interazione per VittoriaOSconfitta.xaml
    /// </summary>
    public partial class VittoriaOSconfitta : Window
    {
        Impostazione impostazioni;
        FinestraGioco _mainGioco;
        MainWindow main;

        public VittoriaOSconfitta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainGioco = new FinestraGioco(main, impostazioni);
            _mainGioco.Show();
            this.Close();
        }
    }
}
