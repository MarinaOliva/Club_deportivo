using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace club_deportivo.Datos
{
    public class Conexion
    {
        // Método para crear la conexión utilizando Program.ConnectionString
        public MySqlConnection CrearConexion()
        {
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                // Usamos Program.ConnectionString que ya contiene la cadena completa
                conexion.ConnectionString = Program.ConnectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar establecer la conexión a la base de datos: " + ex.Message);
                conexion = null;
                throw;
            }

            return conexion;
        }
    }
}
