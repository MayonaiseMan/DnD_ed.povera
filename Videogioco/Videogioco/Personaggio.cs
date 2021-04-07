using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class Personaggio
    {
        public Personaggio()
        {
            throw new System.NotImplementedException();
        }

        string nome;
        public enum razza { elfo = 55, umano = 45, nano = 30, halfling = 70};
        public razza Razza
        {
            get;
            private set;
        }
        double modificatore;
        int HP;
        Arma _armaEqipaggiata;
        Armatura _armaturaEquipaggiata;
        int _abilita1, _abilita2;
        int Ka, Kd;

        public void Scrittura()
        {
            throw new System.NotImplementedException();
        }

        public void Lettura()
        {
            throw new System.NotImplementedException();
        }

        public Abilita AbilitaPossibili
        {
            get => default;
            set
            {
            }
        }

        private int _exp;

        public void UsaAbilita()
        {
            throw new System.NotImplementedException();
        }

        public void Attacca()
        {
            throw new System.NotImplementedException();
        }

        public void Disimpegna()
        {
            throw new System.NotImplementedException();
        }

        public void cambiaEquipaggiamento()
        {
            throw new System.NotImplementedException();
        }

        private string _immagine;

        public void UsaArma()
        {
            throw new System.NotImplementedException();
        }

        public void UsaArmatura()
        {
            throw new System.NotImplementedException();
        }
    }
}