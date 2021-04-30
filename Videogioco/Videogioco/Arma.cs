﻿using System;
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