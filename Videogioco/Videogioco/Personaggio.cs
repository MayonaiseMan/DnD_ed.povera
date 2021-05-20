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
    [XmlRoot(ElementName = "Personaggio")]
    public class Personaggio
    {

        public Personaggio()
        { 
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            
            
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Arma arma)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaEqipaggiata = arma;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Armatura armatura)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaturaEquipaggiata = armatura;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Arma arma, Armatura armatura)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaEqipaggiata = arma;
            _armaturaEquipaggiata = armatura;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, BitmapImage img)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            immagine = img;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Arma arma, BitmapImage img)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaEqipaggiata = arma;
            immagine = img;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Armatura armatura, BitmapImage img)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaturaEquipaggiata = armatura;
            immagine = img;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Arma arma, Armatura armatura, BitmapImage img)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaEqipaggiata = arma;
            _armaturaEquipaggiata = armatura;
            immagine = img;
        }

        [XmlElement(ElementName = "nome")]
        string _nome;
        
        
        public enum razza { elfo = 55, umano = 45, nano = 30, halfling = 70};


        

        [XmlElement(ElementName = "Razza")]
        public razza Razza
        {
            get;
            private set;
        }


        [XmlElement(ElementName = "HP", DataType = "int")]
        int _HP;

        [XmlElement(ElementName = "arma")]
        Arma _armaEqipaggiata;

        [XmlElement(ElementName = "armatura")]
        Armatura _armaturaEquipaggiata;

        [XmlElement(ElementName = "abilita1", DataType = "int")]
        int _abilita1;

        [XmlElement(ElementName = "abilita2", DataType = "int")]
        int _abilita2;

        [XmlElement(ElementName = "Ka", DataType = "int")]
        int _Ka;

        [XmlElement(ElementName = "Kd", DataType = "int")]
        int _Kd;

       
        BitmapImage immagine;

        [XmlElement(ElementName = "img", IsNullable =  true)]
        XElement stringaImg = null;

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
            stringaImg = img;

        }


        public void CaricaImmagine()
        {
            string val = stringaImg.Value;
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


        public Abilita AbilitaPossibili
        {
            get;
            set;         
        }

        private int _exp;

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
    }
}