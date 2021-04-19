using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows;

namespace Videogioco
{
    public class GestoreXml
    {
        public GestoreXml()
        {
            throw new System.NotImplementedException();
        }


        public Impostazione CaricaImpostazioni(string s)
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
                MessageBox.Show("errore caricamento impostazioni audio");   
                return new Impostazione();
            }
        }
    }
}