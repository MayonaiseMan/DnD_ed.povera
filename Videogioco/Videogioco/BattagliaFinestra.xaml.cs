using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Logica di interazione per BattagliaFinestra.xaml
    /// </summary>
    public partial class BattagliaFinestra : Window
    {

        private Thread sposta1;
        private Thread sposta2;


        public BattagliaFinestra(Personaggio personaggio1, Personaggio personaggio2)
        {
            InitializeComponent();

            img1.Source = new BitmapImage(new Uri(personaggio1.PercorsoImmagine, UriKind.Relative));
            img2.Source = new BitmapImage(new Uri(personaggio2.PercorsoImmagine, UriKind.Relative));
            img1.Margin = new Thickness(84, 175, 0, 0);
            img2.Margin = new Thickness(568, 175, 0, 0);
            sposta1 = new Thread(new ThreadStart(Sposta1));
            sposta2 = new Thread(new ThreadStart(Sposta2));
            sposta1.Start();
            sposta2.Start();

        }

        private void Sposta1()
        {
            int margine = 84;

            while (margine < 300)
            {
                margine += 1;

                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    img1.Margin = new Thickness(margine, 175, 0, 0);

                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(5));
            }
        }

        private void Sposta2()
        {
            int margine = 568;

            while (margine > 350)
            {
                margine -= 1;

                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    img2.Margin = new Thickness(margine, 175, 0, 0);

                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(5));
            }
        }
    }
}
