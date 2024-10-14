using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace club_deportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        public Conexion()
        {
            // Asignamos valores a las variables de la conexión
            this.baseDatos = "clubDeportivo_grupo14_comC";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "pass";
        }

        // Proceso de interacción para crear una conexión
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                // Cadena de conexión
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar establecer la conexión a la base de datos: " + ex.Message);
                cadena = null;
                throw;
            }

            return cadena;
        }

        // Método para obtener la instancia de la conexión
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion(); // Se crea una nueva instancia si no existe
            }
            return con;
        }
    }
}
