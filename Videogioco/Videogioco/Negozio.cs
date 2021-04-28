using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Videogioco
{
    [XmlRoot(ElementName = "negozio")]
    public class Negozio
    {

        [XmlElement(ElementName = "Arma")]
        List<Arma> _armi;

        [XmlElement(ElementName = "Armature")]
        List<Armatura> _armature;

        [XmlElement(ElementName = "ultimoAggiornamento")]
        string ultimoAggiornamento;

        public Negozio()
        {

        }

        public Gioco Giocatore
        {
            get;
            set;
        }

        public void Lettura()
        {
            
        }

        public void XpBoost()
        {
            
        }

        public void Scrittura()
        {
            
        }

        public void init()
        {
            
        }
    }
}