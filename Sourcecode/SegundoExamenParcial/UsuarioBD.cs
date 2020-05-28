using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace SegundoExamenParcial
{
    public static class UsuarioBD
    
    {
        public static List<Usuario> getLista()
        {
            string sql = "select * from appuser";

            DataTable dt = ConexionBD.realizarConsulta(sql);

            List<Usuario> lista = new List<Usuario>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Usuario user = new Usuario();
                
                user.NombreUsuario = fila[1].ToString();
                user.UserName = fila[2].ToString();
                user.contrasena = fila[3].ToString();
                user.admin = Convert.ToBoolean(fila[4].ToString());

                lista.Add(user);
            }
            return lista;
        }
        public static void agregarUsuario(Usuario c)
        {
            string sql = String.Format(
                "insert into \"appuser\"" + 
                "(\"fullname\", \"username\", \"password\", \"usertype\")" +
                "values ('{0}','{1}', '{2}', '{3}');",
                c.NombreUsuario, c.UserName, c.contrasena, c.admin);
                
            ConexionBD.realizarAccion(sql);
        }

        public static void actualizarContra(string Contraseña, Usuario user)
        {
            
            try
            {
                string Noquery = $"UPDATE appuser SET password = '{Contraseña}' WHERE \"iduser\" = {user.Userid} ";
                ConexionBD.realizarAccion(Noquery);
                MessageBox.Show($"Se ha actualizado la contraseña de '{user.NombreUsuario}' exitosamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
            
        }
    }
}