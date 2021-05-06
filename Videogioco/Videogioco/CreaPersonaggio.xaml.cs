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
using System.Security;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Videogioco
{
    /// <summary>
    /// Logica di interazione per CreaPersonaggio.xaml
    /// </summary>
    public partial class CreaPersonaggio : Window
    {

        
        FinestraGioco _mainGioco;
        
        Random rnd;
        public CreaPersonaggio(FinestraGioco m)
        {
            InitializeComponent();
            rnd = new Random();
            _mainGioco = m;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            _mainGioco.Show();
            this.Close();
        }

        int hp, ka, kd;

        private void ok_btn_Click(object sender, RoutedEventArgs e)
        {
            if(dado_btn_hp.IsEnabled == false && dado_ka_btn.IsEnabled == false && dado_kd_btn.IsEnabled == false)
            {
                
                
            }
        }

        private void dado_kd_btn_Click(object sender, RoutedEventArgs e)
        {
            kd = 0;
            if (armatura_combo.SelectedItem == null)
            {
                for(int i = 0; i < 3; i++)
                    kd += rnd.Next(1, 11);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                    kd += rnd.Next(1, 11);
            }
        }

        private void dado_ka_btn_Click(object sender, RoutedEventArgs e)
        {
            ka = 0;
            if (arma_combo.SelectedItem == null)
            {

                for (int i = 0; i < 3; i++)
                    ka += rnd.Next(1, 11);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                    ka += rnd.Next(1, 11);
            }
        }

        private void dado_btn_hp_Click(object sender, RoutedEventArgs e)
        {
            
            hp = 0;
            for(int i = 0; i < 3; i++)
                hp += rnd.Next(1, 11);
        }

        private void add_img_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string fileName;
            ofd.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*"; 
            if (ofd.ShowDialog() == true)
            {
                fileName = ofd.FileName;
            }


        }
    }
}
