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
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Media;

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
        SoundPlayer splayer;



        public MainWindow()
        {
            InitializeComponent();
            gestore = new GestoreXml();
            splayer = new SoundPlayer(@"audio\musica1.wav");
            impostazioni = gestore.CaricaImpostazioni(Impostazione.CONFIG_FILE);
            splayer.Play();
        }
      
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            _mainGioco = new FinestraGioco(this, impostazioni);
            _mainGioco.Show();
            this.Close();
        }
    }
}
