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
        [XmlElement(ElementName ="Ka", DataType = "int")]
        private int _valoreAttacco;

        [XmlElement(ElementName = "abilitaArma", DataType = "int")]
        private int _numAbilita;

        [XmlElement(ElementName = "genere", DataType = "genereArma")]
        public genereArma Genere { get; private set; }

        public enum genereArma {Pugnale = 1, SpadaLunga = 2, Maglio = 3, AsciaBipenne = 4, Randello = 5, Balestra = 6, Scimitarra = 7};

        public Arma(string nome, int rare, int acquisto, int vendita, int numAb, int K) : base(nome, rare, acquisto, vendita)
        {
            if(numAb >= 1 && numAb <= 2)
            {
                _numAbilita = numAb;
            }

            if(K >= 1 && K <= 12)
            {
                _valoreAttacco = K;
            }

            
        }

        void CreaAbilita()
        {
            AbilitaArma = new AbilitaArmi(this);
        }

        void UsaAbilità()
        {

        }


        
        public AbilitaArmi AbilitaArma
        {
            get;
            set;
        }
    }
}