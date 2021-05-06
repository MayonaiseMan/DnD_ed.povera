using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Videogioco
{
    [XmlRoot(ElementName ="Gioco")]
    public class Gioco
    {
        [XmlElement(ElementName ="Soldi")]
        private int _soldi;

        public bool XpBoost = false;

        public GestoreXml Gestore
        {
            get;
            set;
        }

        public int Soldi
        {
            get
            {
                return _soldi;
            }

            set
            {
                if (value > 0)
                    _soldi = value;
            }
        }

        public Gioco()
        {
            Gestore = new GestoreXml(this);
        }

        public Negozio Shop
        {
            get;
            private set;
        }

        public Battaglia Battle
        {
            get;
            private set;
        }

        public List<Personaggio> Personaggi
        {
            get;
            private set;
        }

        public Impostazione Impostazioni
        {
            get;
            private set;
        }

        public FinestraInventario Inventario
        {
            get;
            private set;
        }

        public Statistiche Stat
        {
            get;
            private set;
        }

        public void Scrittura()
        {
             
        }

        public void Lettura()
        {
             
        }

        public void CreaPersonaggio()
        {
             
        }

        public void ApriInventario()
        {
             
        }

        public void ApriNegozioo()
        {
             
        }

        public void ApriStat()
        {
             
        }
    }
}