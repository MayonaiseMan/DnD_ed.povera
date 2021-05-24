using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows;
using System.ComponentModel;
using System.Xml.Linq;
using System.IO;
using System.Drawing;
using System.Windows.Interop;


namespace Videogioco
{
    public class Personaggio
    {
        string _nome;

        string _razza;

        int _HP;

        int _attacco;

        int _difesa;

        string _percorsoImmagine;

        BitmapImage immagine;

        public Personaggio()
        { 

        }

        public Personaggio(string nome, string r, int puntiVita, int Katt, int Kdif, string percorsoImmagine)
        {
            if (string.IsNullOrEmpty(nome) == false)
                Nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                PuntiVita = puntiVita;
            else
                throw new Exception("hp non validi");

            Attacco = Katt;

            Difesa = Kdif;

            PercorsoImmagine = percorsoImmagine;
        }

        public void AddImg(BitmapImage img)
        {
            immagine = img;
            GenereStringaImmagine();
        }

        public void GenereStringaImmagine()
        {
            BitmapImage bmp =  immagine;
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BitmapImage));
            XElement img = new XElement("image",
                Convert.ToBase64String(
                    (byte[])converter.ConvertTo(bmp, typeof(byte[]))));
            PercorsoImmagine = bmp.UriSource.ToString();

        }


        public void CaricaImmagine()
        {
            string val = PercorsoImmagine;
            byte[] bytes = Convert.FromBase64String(val);
            MemoryStream mem = new MemoryStream(bytes);
            Bitmap bmp2 = new Bitmap(mem);


            IntPtr hBitmap = bmp2.GetHbitmap();
            BitmapImage retval;

            try
            {
                retval = (BitmapImage)Imaging.CreateBitmapSourceFromHBitmap(
                             hBitmap,
                             IntPtr.Zero,
                             Int32Rect.Empty,
                             BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                
            }

            immagine = retval;
        }

      

        public void Scrittura()
        {
             
        }

        public void Lettura()
        {
             
        }

        public void UsaAbilita()
        {
             
        }

        public void Attacca()
        {
             
        }

        public void Disimpegna()
        {
             
        }

        public void cambiaEquipaggiamento()
        {
             
        }

        

        public void UsaArma()
        {
             
        }

        public void UsaArmatura()
        {
             
        }

        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
            }
        }

        public string Razza
        {
            get => _razza;
            set
            {
                _razza = value;
            }
        }

        public int PuntiVita
        {
            get => _HP;
            set
            {
                _HP = value;
            }
        }

        public int Attacco
        {
            get => _attacco;
            set
            {
                _attacco = value;
            }
        }

        public int Difesa
        {
            get => _difesa;
            set
            {
                _difesa = value;
            }
        }

        public string PercorsoImmagine
        {
            get => _percorsoImmagine;
            set
            {
                _percorsoImmagine = value;
            }
        }

        [XmlIgnore]
        public BitmapImage Immagine
        {
            get => immagine;
            set
            {
                immagine = value;
            }
        }

        /*public Abilita AbilitaPossibili
        {
            get;
            set;
        }*/

        public override string ToString()
        {
            return Nome;
        }
    }
}