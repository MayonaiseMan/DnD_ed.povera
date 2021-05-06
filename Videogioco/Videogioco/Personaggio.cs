using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace Videogioco
{
    [XmlRoot(ElementName = "Personaggio")]
    public class Personaggio
    {
        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Arma arma)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaEqipaggiata = arma;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Armatura armatura)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaturaEquipaggiata = armatura;
        }

        public Personaggio(string nome, razza r, int puntiVita, int A1, int A2, int Katt, int Kdif, Arma arma, Armatura armatura)
        {
            if (string.IsNullOrEmpty(nome) == false)
                _nome = nome;
            else
                throw new Exception("nome non valido");

            Razza = r;
            if (puntiVita > 3 && puntiVita <= 18)
                _HP = puntiVita;
            else
                throw new Exception("hp non validi");

            _abilita1 = A1;
            _abilita2 = A2;
            _Ka = Katt;
            _Kd = Kdif;
            _armaEqipaggiata = arma;
            _armaturaEquipaggiata = armatura;
        }

        [XmlElement(ElementName = "nome")]
        string _nome;
        
        
        public enum razza { elfo = 55, umano = 45, nano = 30, halfling = 70};

        [XmlElement(ElementName = "Razza", DataType = "razza")]
        public razza Razza
        {
            get;
            private set;
        }


        [XmlElement(ElementName = "HP", DataType = "int")]
        int _HP;

        [XmlElement(ElementName = "arma", DataType = "Arma")]
        Arma _armaEqipaggiata;

        [XmlElement(ElementName = "armatura", DataType = "Armatura")]
        Armatura _armaturaEquipaggiata;

        [XmlElement(ElementName = "abilita1", DataType = "int")]
        int _abilita1;

        [XmlElement(ElementName = "abilita2", DataType = "int")]
        int _abilita2;

        [XmlElement(ElementName = "Ka", DataType = "int")]
        int _Ka;

        [XmlElement(ElementName = "Kd", DataType = "int")]
        int _Kd;

        [XmlElement(ElementName = "img")]
        string img;


        public void Addimg()
        {

        }

        public void Scrittura()
        {
             
        }

        public void Lettura()
        {
             
        }


        public Abilita AbilitaPossibili
        {
            get;
            set;         
        }

        private int _exp;

        public void UsaAbilita()
        {
             
        }

        public void Attacca()
        {
             
        }

        public void Disimpegna()
        {
             
        }

        public void cambiaEquipaggiamento()
        {
             
        }

        

        public void UsaArma()
        {
             
        }

        public void UsaArmatura()
        {
             
        }
    }
}