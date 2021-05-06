﻿using System;
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
            throw new System.NotImplementedException();
        }

        public void Lettura()
        {
            throw new System.NotImplementedException();
        }

        public void CreaPersonaggio()
        {
            throw new System.NotImplementedException();
        }

        public void ApriInventario()
        {
            throw new System.NotImplementedException();
        }

        public void ApriNegozioo()
        {
            throw new System.NotImplementedException();
        }

        public void ApriStat()
        {
            throw new System.NotImplementedException();
        }
    }
}