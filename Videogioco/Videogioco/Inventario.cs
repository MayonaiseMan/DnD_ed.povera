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

        }

        public Gioco Giocatore
        {
            get => default;
            set
            {

            }
        }



        public void Aggiungi(Arma a)
        {
            _armiPossedute.Add(a);
        }

        public void Aggiungi(Armatura a)
        {
            _armaturePossedute.Add(a);
        }
         
        public void GetArmi()
        {

        }

        public void GetArmatura()
        {

        }
    }
}
