﻿using System.Data;
using Npgsql;

namespace Preparcial.Controlador
{
    public static class ConexionBD
    {
        // Cadena de conexion
        //cambio de los datos de la base original para que funcione correctamente la mia.
        private static string cadenaC = "Server=127.0.0.1;" +
                                        "Port=5432;" +
                                        "UserId=postgres;" +
                                        "Password=1234505;" +
                                        "Database=Preparcial1;";

        // Ejecutar consulta (Comando SELECT)
        public static DataTable EjecutarConsulta(string consulta)
        {
            var conn = new NpgsqlConnection(cadenaC);
            var ds = new DataSet();

            conn.Open();
            var da = new NpgsqlDataAdapter(consulta, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        // Ejecutar comando (UPDATE, INSERT, DELETE, ETC)
        public static void EjecutarComando(string comando)
        {
            var conn = new NpgsqlConnection(cadenaC);

            conn.Open();
            var comm = new NpgsqlCommand(comando, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}