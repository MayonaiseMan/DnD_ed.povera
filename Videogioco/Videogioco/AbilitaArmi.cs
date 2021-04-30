using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    
    public class AbilitaArmi
    {

        Arma _arma;
        public AbilitaArmi(Arma a)
        {
            _arma = a;
        }

        public void Seleziona(int numAbilita)
        {
            switch(numAbilita)
            {
                case 1:
                    Potenziamento(_arma);
                    break;
                case 2:
                    Concentrazione(_arma);
                    break;

            }
        }

        public void Potenziamento(Arma a)
        {

        }

        public void Concentrazione(Arma a)
        {
            
        }
    }
}