using System;

namespace SegundoExamenParcial
{
    public class OrdenClass
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }

        public OrdenClass()
        {
            idOrder = 0;
            idProduct = 0;
            createDate = DateTime.Now;
            idAddress = 0;
        }
    }
}