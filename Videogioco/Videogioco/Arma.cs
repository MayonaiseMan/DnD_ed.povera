using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Videogioco
{
    [XmlRoot(ElementName ="Arma")]
    public class Arma : Equipaggiamento
    {
        [XmlElement(ElementName ="Ka")]
        private int _valoreAttacco;

        [XmlElement(ElementName = "abilitaArma")]
        private int _numAbilita;

        public Arma()
        {
            
        }

        
        public AbilitaArmature AbilitaArmature
        {
            get => default;
            set
            {
            }
        }
    }
}