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

        public Armatura(string nome, int rare, int acquisto, int vendita, int numAb, int K) :base(nome, rare, acquisto, vendita)
        {
            if (numAb >= 1 && numAb <= 2)
            {
                _numAbilita = numAb;
            }

            if (K >= 1 && K <= 12)
            {
                _valoreDifesa = K;
            }
        }

        void CreaAbilita()
        {
            AbilitaArmetura = new AbilitaArmature(this);
        }


        public AbilitaArmature AbilitaArmetura
        {
            get;
            set;
            
        }
    }
}