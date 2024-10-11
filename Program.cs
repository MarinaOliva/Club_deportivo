using System;
using MySql.Data.MySqlClient;
using club_deportivo.Datos;
using System.Diagnostics;


// Esto se va a borrar después, es para probar que la conexión funciona nomás (hasta que tengamos corriendo las ventanas)
class Program
{
    static void Main(string[] args)
    {
        // Obtener la instancia de la conexión
        Conexion conexionBD = Conexion.getInstancia();

        // Intentar crear una conexión a la base de datos
        try
        {
            using (MySqlConnection conexion = conexionBD.CrearConexion())
            {
                conexion.Open();  // Abre la conexión

                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    Debug.WriteLine("Conexión exitosa a la base de datos.");
                }
                else
                {
                    Debug.WriteLine("Error al conectar a la base de datos.");
                }
            }
        }
        catch (MySqlException ex)
        {
            Debug.WriteLine("Error de MySQL: " + ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error general: " + ex.Message);
        }
    }
}
