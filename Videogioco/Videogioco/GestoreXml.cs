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
        public GestoreXml(Gioco gioco)
        {
            this.gioco = gioco;
            gioco.Personaggi = CaricaPersonaggio("Personaggi.xml");
        }

        public GestoreXml()
        {

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
                 
                return new Impostazione(true);
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

        private List<Personaggio> CaricaPersonaggio(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Personaggio>));

                using (StreamReader sr = new StreamReader(path))
                {
                    if (sr.ReadLine() != null)
                    {
                        return serializer.Deserialize(sr) as List<Personaggio>;
                    }
                    else
                    {
                        return new List<Personaggio>();
                    }
                    
                }            
            }
            catch (Exception ex)
            {
                throw ex;    
            }
        }

        public void ScriviPersonaggio(string path, Personaggio p)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Personaggio>));



                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    serializer.Serialize(sw, p);
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