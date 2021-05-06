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
        public GestoreXml(Gioco g)
        {
            gioco = g;
        }

        Gioco gioco;

        public Impostazione CaricaImpostazioni(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Impostazione));

                Impostazione tmp;

                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    tmp = (Impostazione)serializer.Deserialize(reader);
                }

                tmp.gioco = gioco;
                return tmp;
            }
            catch(Exception ex)
            {
                 
                return new Impostazione();
            }        
        
        }

        public void ScriviImpostazioni(string path)
        {

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Impostazione));



                using (Stream writer = new FileStream(path, FileMode.Open))
                {
                    serializer.Serialize(writer, gioco.Impostazioni);
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public Negozio CaricaNegozio(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Negozio));

                Negozio tmp;

                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    tmp = (Negozio)serializer.Deserialize(reader);
                }

                tmp.Giocatore = gioco;
                return tmp;
            }
            catch (Exception ex)
            {

                return new Negozio();
            }
        }

        

        public void ScriviNegozio(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Negozio));



                using (Stream writer = new FileStream(path, FileMode.Open))
                {
                    serializer.Serialize(writer, gioco.Shop);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Personaggio CaricaPersonaggio(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Personaggio));

                Personaggio tmp;

                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    tmp = (Personaggio)serializer.Deserialize(reader);
                }

                
                return tmp;
            }
            catch (Exception ex)
            {
                return null;                
            }
        }

        public void ScriviPersonaggio(string path, Personaggio p)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Personaggio));



                using (Stream writer = new FileStream(path, FileMode.Open))
                {
                    serializer.Serialize(writer, p);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        public void ScriviInventario(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Inventario));



                using (Stream writer = new FileStream(path, FileMode.Open))
                {
                    serializer.Serialize(writer, gioco.Inventario);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public Inventario CaricaInventario(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Inventario));

                Inventario tmp;

                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    tmp = (Inventario)serializer.Deserialize(reader);
                }

                tmp.Giocatore = gioco;
                return tmp;
            }
            catch (Exception ex)
            {

                return new Inventario();
            }
        }

        

    }
}