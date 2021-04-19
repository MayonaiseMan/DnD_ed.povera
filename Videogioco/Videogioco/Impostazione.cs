using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using System.Threading;
using System.Threading.Tasks;

namespace Videogioco
{
    
    [XmlRoot(ElementName="impostazioni")]
    public class Impostazione
    {
        [XmlElement(ElementName ="Effetti")]
        private bool _effetti;
        [XmlElement(ElementName = "Bgm")]
        private bool _bgm;

        public const string CONFIG_FILE = ".\\file\\config.xml";
        public const string PERCORSO_BGM = ".\\audio\\effetti.mp3";
        public const string PERCORSO_MUSICA = ".\\audio\\musica.mp3";



        OpenFileDialog effetti;
        MediaPlayer mediaEffetti;
        OpenFileDialog musica;
        MediaPlayer mediaMusica;

        public Impostazione()
        {
            _bgm = true;
            _effetti = true;


            effetti = new OpenFileDialog();
            mediaEffetti = new MediaPlayer();

            musica = new OpenFileDialog();
            mediaMusica = new MediaPlayer();

        }



        public void EffettiOnOff()
        {
            if (_effetti == true)
                _effetti = false;
            else
                _effetti = true;
        }

        public void BgmOnOff()
        {
            if (_bgm == true)
                _bgm = false;
            else
                _bgm = true;

            AggiornaAudio();
        }

        

        public void RiproduciEffetti()
        {
            mediaEffetti.Open(new Uri(effetti.FileName,UriKind.RelativeOrAbsolute));
            mediaEffetti.Play();          
        }

        private async void RiproduciMusica()
        {
            await Task.Run(() => {
                mediaMusica.Open(new Uri(musica.FileName));
                mediaMusica.Play();
                if (_bgm == true)
                    RiproduciMusica();                
            
            });
        }

        


        public void AggiornaAudio()
        {
            if(_effetti == true)
            {
                
                effetti.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                effetti.FileName =PERCORSO_BGM ;
            }
            else
            {
                effetti.FileName = "";
            }

            if (_bgm == true)
            {
                musica.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                musica.FileName = PERCORSO_MUSICA;
                RiproduciMusica();
            }
            else
            {
                effetti.FileName = "";
                mediaMusica.Stop();
            }


        }
    }
}