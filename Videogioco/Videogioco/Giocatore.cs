using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class Giocatore
    {
        private int _soldi;

        public Giocatore()
        {
            throw new System.NotImplementedException();
        }

        public Negozio Shop
        {
            get => default;
            set
            {
            }
        }

        public Battaglia Battle
        {
            get => default;
            set
            {
            }
        }

        public List<Personaggio> Personaggi
        {
            get => default;
            set
            {
            }
        }

        public Videogioco.Impostazione Impostazioni
        {
            get => default;
            set
            {
            }
        }

        public Videogioco.Inventario Inventario
        {
            get => default;
            set
            {
            }
        }

        public Videogioco.Statistiche Stat
        {
            get => default;
            set
            {
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

        public void CreaPersonaggio()
        {
            throw new System.NotImplementedException();
        }

        public void ApriInventario()
        {
            throw new System.NotImplementedException();
        }

        public void ApriNegozioo()
        {
            throw new System.NotImplementedException();
        }

        public void ApriStat()
        {
            throw new System.NotImplementedException();
        }
    }
}