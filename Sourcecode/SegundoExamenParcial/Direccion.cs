using System;

namespace SegundoExamenParcial
{
    public class Direccion
    {
        public int idAddress { get; set; }
        public int iduser { get; set; }
        public string address { get; set; }
        
        public Direccion()
        {
            idAddress = 0;
            iduser = 0;
            address = " ";
        }

    }
}