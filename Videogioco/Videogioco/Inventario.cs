using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace Videogioco
{
    public class Inventario
    {

        [XmlElement(ElementName = "Armi", DataType = "Arma")]
        List<Arma> _armiPossedute;

        [XmlElement(ElementName = "Armature", DataType = "armature")]
        List<Armatura> _armaturePossedute;


        public Inventario()
        {
            _armaturePossedute = new List<Armatura>();
            _armiPossedute = new List<Arma>();
            
        }

        public Gioco Giocatore
        {
            get;
            set;            
        }



        public void Aggiungi(Arma a)
        {
            _armiPossedute.Add(a);
        }

        public void Aggiungi(Armatura a)
        {
            _armaturePossedute.Add(a);
        }
         
        public Arma GetArma(int index)
        {
            Arma a = _armiPossedute[index];
            _armiPossedute.Remove(a);
            return a;
        }

        public Armatura GetArmatura(int index)
        {
            Armatura a = _armaturePossedute[index];
            _armaturePossedute.Remove(a);
            return a;
        }
    }
}
