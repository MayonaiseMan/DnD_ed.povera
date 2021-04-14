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
        MainWindow _main;

        public FinestraGioco(MainWindow main, Impostazione i)
        {
            InitializeComponent();
            gioco = new Gioco();

        }


    }
}
