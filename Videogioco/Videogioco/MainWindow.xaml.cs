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

        public MainWindow()
        {
            InitializeComponent();

            impostazioni = CaricaImpostazioni(Impostazione.CONFIG_FILE);
            impostazioni.AggiornaAudio();
        }

        private Impostazione CaricaImpostazioni(string s)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Impostazione));

                Impostazione tmp;

                using (Stream reader = new FileStream(s, FileMode.Open))
                {
                    tmp = (Impostazione)serializer.Deserialize(reader);
                }

                return tmp;
            }
            catch
            {
                return new Impostazione();
            }
        }

        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            _mainGioco = new FinestraGioco(this, impostazioni);
            _mainGioco.Show();
            this.Hide();
        }
    }
}
