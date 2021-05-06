using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace Videogioco
{
    [XmlRoot(ElementName = "negozio")]
    public class Negozio
    {        


        [XmlElement(ElementName = "Armi")]
        List<Arma> _armi;

        [XmlElement(ElementName = "Armature")]
        List<Armatura> _armature;

        [XmlElement(ElementName = "ultimoAggiornamento")]
        string ultimoAggiornamento;

        public Negozio()
        {
            ultimoAggiornamento = "";
            _armature = new List<Armatura>();
            _armi = new List<Arma>();
            //Riempi();
        }

        public Gioco Giocatore
        {
            get;
            set;
        }

        public bool check()
        {
            string giorno = "" + DateTime.Today.Day;
            string mese = "" + DateTime.Today.Month;
            string oggi = giorno + "/" + mese;

            if (giorno != ultimoAggiornamento)
            {
                SvuotaNegozio();
                //Riempi();
                ultimoAggiornamento = oggi;
                return false;
            }
            

            return true;
        }

        private void SvuotaNegozio()
        {
            _armi.Clear();
            _armature.Clear();
        }

        private void Riempi()
        {
            Random rnd = new Random();
            List<List<string>> nomiArmi = GetNomiArmi();
            List<List<string>> nomiArmature = GetNomiArmature();

            for(int i = 0; i < 10; i++)
            {
                Arma.genereArma gen = (Arma.genereArma)rnd.Next(1, 8);
                int numA = rnd.Next(1, 3);
                int tmp = rnd.Next(0, 10);
                string nome = nomiArmi[(int)gen][tmp];


                GeneratoreOggetti generatore = new GeneratoreOggetti();
                Arma a = generatore.GeneraArma(nome, numA, gen);
                _armi.Add(a);
            }

            for (int i = 0; i < 10; i++)
            {
                Armatura.genereArmatura gen = (Armatura.genereArmatura)rnd.Next(1, 4);
                int numA = rnd.Next(1, 3);
                int tmp = rnd.Next(0, 10);
                string nome = nomiArmi[(int)gen][tmp];


                GeneratoreOggetti generatore = new GeneratoreOggetti();
                Armatura a = generatore.GeneraArmatura(nome, numA, gen);
                _armature.Add(a);
            }

        }

        private List<List<string>> GetNomiArmi()
        {
            string path = ".\\data\\nomi_oggetti\\armi";
            string[] files = Directory.GetFiles(path);

            List<List<string>> nomiArmi = new List<List<string>>();


            foreach (string file in files)
            {
                List<string> tmp = new List<string>();
                using (StreamReader reader = new StreamReader(file))
                {
                    while (reader.EndOfStream == false)
                    {
                        string tm = reader.ReadLine();
                        tmp.Add(tm);

                    }
                    nomiArmi.Add(tmp);
                }
            }

            return nomiArmi;
        }

        private List<List<string>> GetNomiArmature()
        {
            string path = ".\\data\\nomi_oggetti\\armature";
            string[] files = Directory.GetFiles(path);

            List<List<string>> nomiArmature = new List<List<string>>();


            foreach (string file in files)
            {
                List<string> tmp = new List<string>();
                using (StreamReader reader = new StreamReader(file))
                {
                    while (reader.EndOfStream == false)
                    {
                        string tm = reader.ReadLine();
                        tmp.Add(tm);

                    }
                    nomiArmature.Add(tmp);
                }
            }

            return nomiArmature;
        }

        

        public async void XpBoost(int soldiSpesi)
        {
            if(soldiSpesi > 0 && soldiSpesi <= 100)
            {
                Giocatore.XpBoost = true;
                await Task.Run(() => {

                    Thread.Sleep(soldiSpesi * 1000);
                    Giocatore.XpBoost = false;
                });
            }
        }

        public void Acquista(Arma a)
        {
            if(Giocatore.Soldi >= a.Acquista)
            {
                Giocatore.Soldi -= a.Acquista;
                Giocatore.Inventario.Aggiungi(a);
                _armi.Remove(a);
            }
        }

        public void Acquista(Armatura a)
        {
            if (Giocatore.Soldi >= a.Acquista)
            {
                Giocatore.Soldi -= a.Acquista;
                Giocatore.Inventario.Aggiungi(a);
                _armature.Remove(a);
            }
        }


    }
}