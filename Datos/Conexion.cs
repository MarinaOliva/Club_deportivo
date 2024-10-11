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
            baseDatos = "proyecto";
            servidor = "localhost";
            puerto = "3306";
            usuario = "root";
            clave = "pass"; 
        }

        // Proceso de interacción para crear una conexión
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                // Cadena de conexión
                cadena.ConnectionString = "datasource=" + servidor +
                                          ";port=" + puerto +
                                          ";username=" + usuario +
                                          ";password=" + clave +
                                          ";Database=" + baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }

            return cadena;
        }

        public void InicializarBaseDeDatos()
        {
            using (var conexion = CrearConexion())
            {
                conexion.Open();

                // Comprobar si la base de datos ya existe
                var cmd = new MySqlCommand("SHOW DATABASES LIKE '" + baseDatos + "';", conexion);
                var reader = cmd.ExecuteReader();

                if (!reader.HasRows) // Si no existe la base de datos
                {
                    reader.Close();
                    Console.WriteLine("Base de datos no encontrada. Creando la base de datos...");

                    // Leer el script SQL desde el archivo en la carpeta "datos"
                    string script = File.ReadAllText("BaseDatos/proyecto.sql");
                    var cmdCrearBD = new MySqlCommand(script, conexion);
                    cmdCrearBD.ExecuteNonQuery();

                    Console.WriteLine("Base de datos creada correctamente.");
                }
                else
                {
                    Console.WriteLine("La base de datos ya existe.");
                }
            }
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
