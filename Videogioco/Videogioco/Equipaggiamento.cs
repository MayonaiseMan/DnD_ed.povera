using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace Videogioco
{
    public abstract class Equipaggiamento
    {

        [XmlElement(ElementName = "nome")]
        public string _nome;
        
        public enum rare {comune, raro, speciale, divino, singolarita };

        [XmlElement(ElementName = "rarita", DataType = "rare")]
        public rare _rarita;

        [XmlElement(ElementName = "acquisto", DataType = "int")]
        public int _buy;

        [XmlElement(ElementName = "vendita", DataType = "int")]
        public int _sell;

        public Equipaggiamento(string n, int r, int b, int s)
        {
            _nome = n;
            if(r >= 0 && r <= 4)
            {
                _rarita = (rare)r;
            }
            if(b > 0 && s > 0 && b >= s)
            {
                _buy = b;
                _sell = s;
            }
        }

        public int Acquista
        {
            get
            {
                return _buy;
            }
            
        }

        public int Vendita
        {
            get
            {
                return _sell;
            }
           

        }

        public rare Rarita
        {
            get
            {
                return _rarita;
            }
           
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
           
        }
       
    }
}