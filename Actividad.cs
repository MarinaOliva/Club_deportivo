using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string NombreActividad { get; set; }
        public decimal Costo { get; set; }
        public int CuposDisponibles { get; set; }

        // Método para ver si hay cupos disponibles
        public static bool HayCuposDisponibles(int idActividad)
        {
            try
            {
                // Crear conexión a la base de datos
                MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                // Consulta SQL para obtener los cupos disponibles
                string query = "SELECT cuposDisponibles FROM Actividad WHERE idActividad = @idActividad";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idActividad", idActividad);

                // Ejecutar la consulta y obtener el número de cupos
                object result = cmd.ExecuteScalar();
                conexion.Close();

                if (result != null && Convert.ToInt32(result) > 0)
                {
                    return true;  // Hay cupos disponibles
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar los cupos de la actividad: " + ex.Message);
            }

            return false;  // No hay cupos disponibles
        }

        // Método para actualizar los cupos de la actividad
        public static void ActualizarCupos(int idActividad)
        {
            try
            {
                // Obtener la conexión
                MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                // Consultar el número actual de cupos disponibles
                string query = "SELECT cuposDisponibles FROM Actividad WHERE idActividad = @idActividad";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idActividad", idActividad);
                int cuposDisponibles = Convert.ToInt32(cmd.ExecuteScalar());

                // Si hay cupos disponibles, restamos uno
                if (cuposDisponibles > 0)
                {
                    string updateQuery = "UPDATE Actividad SET cuposDisponibles = cuposDisponibles - 1 WHERE idActividad = @idActividad";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conexion);
                    updateCmd.Parameters.AddWithValue("@idActividad", idActividad);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para esta actividad.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los cupos: " + ex.Message);
            }
        }

        // Método para obtener el ID de una actividad
        public static int ObtenerIdActividad(string nombreActividad)
        {
            try
            {
                // Crear conexión a la base de datos
                MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
                conexion.Open();

                // Consulta SQL para obtener el ID de la actividad
                string query = "SELECT idActividad FROM Actividad WHERE nombreActividad = @nombreActividad";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombreActividad", nombreActividad);

                // Ejecutar la consulta y obtener el ID
                object result = cmd.ExecuteScalar();
                conexion.Close();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de la actividad: " + ex.Message);
            }

            // Si no se encuentra la actividad, devolver -1
            return -1;
        }

    }

}
