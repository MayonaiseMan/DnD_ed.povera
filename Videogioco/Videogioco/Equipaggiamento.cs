using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public abstract class Equipaggiamento
    {
        private string _nome;
        public enum ra {comune, raro, speciale, divino, singolarita };
        ra _rarita;
        double _modificatore;
        int _buy, _sell;

        public void Scrittura()
        {
            throw new System.NotImplementedException();
        }

        public void Lettura()
        {
            throw new System.NotImplementedException();
        }
    }
}