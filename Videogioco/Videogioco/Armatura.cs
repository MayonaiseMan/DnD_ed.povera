using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Videogioco
{
    [XmlRoot(ElementName = "armature")]
    public class Armatura : Equipaggiamento
    {
        [XmlElement(ElementName = "Kd")]
        private int _valoreDifesa;

        [XmlElement(ElementName = "abilitaArmatura")]
        private int _numAbilita;

        public Armatura()
        {
            
        }


        public AbilitaArmi AbilitaArmi
        {
            get => default;
            set
            {
            }
        }
    }
}