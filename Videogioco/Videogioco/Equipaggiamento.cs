using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public abstract class Equipaggiamento
    {
        private string _nome;
        public enum rare {comune, raro, speciale, divino, singolarita };
        rare _rarita;
        int _buy, _sell;

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