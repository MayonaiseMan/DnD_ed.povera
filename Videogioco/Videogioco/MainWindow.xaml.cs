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
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Impostazione impostazioni;
        FinestraGioco _mainGioco;
        GestoreXml gestore;

        public MainWindow()
        {
            InitializeComponent();
            gestore = new GestoreXml();

            //impostazioni = gestore.CaricaImpostazioni(Impostazione.CONFIG_FILE);
            //impostazioni.AggiornaAudio();
        }
      
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            _mainGioco = new FinestraGioco(this, impostazioni);
            _mainGioco.Show();
            this.Close();
        }
    }
}
