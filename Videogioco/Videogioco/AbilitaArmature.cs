using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class AbilitaArmature
    {
        Armatura _armatura;
        public AbilitaArmature(Armatura armat)
        {
            _armatura = armat;
        }

        public void Seleziona(int a)
        {
            switch(a)
            {
                case 1:
                    break;
                    Rafforzamento();
                case 2:
                    AumentoVelocita();
                    break;
            }
        }

        public void Rafforzamento()
        {
            
        }

        public void AumentoVelocita()
        {
            
        }
    }
}