using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SegundoExamenParcial
{
    public class AddresBD
    {
        public static List<Direccion> getLista()
        {
            string sql = "select * from appuser";

            DataTable dt = ConexionBD.realizarConsulta(sql);

            List<Direccion> lista = new List<Direccion>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Direccion direccion = new Direccion();
                
                direccion.idAddress = Convert.ToInt32(fila[0]);
                direccion.iduser =  Convert.ToInt32(fila[1]);
                direccion.address = fila[2].ToString();

                lista.Add(direccion);    
            }
            return lista;
        }
        public static void AgregarDireccion(int iduser, string address)
        {
            string sql = $"INSERT INTO address(\"idUser\", address) VALUES(" +
                         $"{iduser}, " +
                         $"'{address}')";

                ConexionBD.realizarAccion(sql);
        }

        public static void EliminarDireccion(int adresss1, object idAddress)
        {
            try
            {
                string nQ = String.Format(
                    $"DELETE FROM apporder WHERE \"idAddress\"= {idAddress}; "+
                    $"DELETE FROM address WHERE \"idAddress\" = {idAddress}");
                ConexionBD.realizarAccion(nQ);
                MessageBox.Show("Se ha eliminado con exito");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }
    }
}
    