using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class GeneratoreOggetti
    {
        const int Acq = 200;
        const int Ven = 100;

        public GeneratoreOggetti()
        {

        }

        public Arma GeneraArma(string s, int numA, Arma.genereArma g)
        {
            try
            {
                Random rnd = new Random();
                int rare = rnd.Next(1, 2);
                int K;
                int tmp = (int)g;
                switch (tmp)
                {
                    case 1:
                        K = 3;
                        break;
                    case 2:
                        K = 4;
                        break;
                    case 3:
                        K = 4;
                        break;
                    case 4:
                        K = 5;
                        break;
                    case 5:
                        K = 2;
                        break;
                    case 6:
                        K = 2;
                        break;
                    case 7:
                        K = 3;
                        break;
                    default:
                        K = -1;
                        break;
                }

                int Ca = rare * Acq * K; //costo acquisto
                int Cb = rare * Ven * K; //costo vendita

                return new Arma(s, rare, Ca, Cb, numA, K);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public Armatura GetArmatura(string n, int numA, Armatura.genereArmatura g)
        {
            try
            {
                Random rnd = new Random();
                int rare = rnd.Next(1, 2);
                int K;
                int tmp = (int)g;
                switch (tmp)
                {
                    case 1:
                        K = 6;
                        break;
                    case 2:
                        K = 9;
                        break;
                    case 3:
                        K = 12;
                        break;
                    default:
                        K = -1;
                        break;
                }

                int Ca = rare * Acq * tmp; //costo acquisto armature
                int Cb = rare * Ven * tmp; //costo vendita armature

                return new Armatura(n, rare, Ca, Cb, numA, K);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}