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

        public Actividad(int idActividad)
        {
            this.IdActividad = idActividad;
        }

        // Método para verificar si hay cupos disponibles
        public bool HayCuposDisponibles()
        {
            try
            {
                // Crear conexión a la base de datos                
                MySqlConnection conexion = new MySqlConnection(Program.ConnectionString);
                conexion.Open();

                // Consulta SQL para obtener los cupos disponibles
                string query = "SELECT cuposDisponibles FROM Actividad WHERE idActividad = @idActividad";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idActividad", this.IdActividad);

                // Ejecutar la consulta y obtener el número de cupos
                object result = cmd.ExecuteScalar();
                conexion.Close();

                // Si cuposDisponibles es NULL, permite la inscripción
                if (result == null || result == DBNull.Value)
                {
                    return true; // Inscripción permitida (cupo ilimitado)
                }

                int cuposDisponibles = Convert.ToInt32(result);

                // Permite la inscripción solo si hay cupos disponibles (> 0)
                return cuposDisponibles > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar los cupos de la actividad: " + ex.Message);
            }

            return false;  // No hay cupos disponibles
        }

        // Método para actualizar los cupos de la actividad
        public void ActualizarCupos()
        {
            try
            {
                // Obtener la conexión
                MySqlConnection conexion = new MySqlConnection(Program.ConnectionString);
                conexion.Open();

                // Consultar el número actual de cupos disponibles
                string query = "SELECT cuposDisponibles FROM Actividad WHERE idActividad = @idActividad";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idActividad", this.IdActividad);
                object result = cmd.ExecuteScalar();

                // Si cuposDisponibles es NULL, no actualizamos nada, pero la inscripción fue exitosa
                if (result == null || result == DBNull.Value)
                {
                    MessageBox.Show("Inscripción exitosa.");
                    conexion.Close();
                    return;
                }

                int cuposDisponibles = Convert.ToInt32(result);

                // Si hay cupos disponibles (> 0), actualizamos
                if (cuposDisponibles > 0)
                {
                    string updateQuery = "UPDATE Actividad SET cuposDisponibles = cuposDisponibles - 1 WHERE idActividad = @idActividad";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conexion);
                    updateCmd.Parameters.AddWithValue("@idActividad", this.IdActividad);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Inscripción exitosa. Cupo actualizado.");
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para esta actividad.");
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los cupos: " + ex.Message);
            }
        }
        

        // Método para obtener el ID de una actividad desde su nombre
        public static int ObtenerIdActividad(string nombreActividad)
        {
            try
            {
                // Crear conexión a la base de datos
                MySqlConnection conexion = new MySqlConnection(Program.ConnectionString);
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

        // Método para inscribir un socio a una actividad
        public static bool InscribirSocio(int socioID, int actividadID)
        {
            try
            {
                // Verificar si hay cupos disponibles
                Actividad actividad = new Actividad(actividadID); 
                if (actividad.HayCuposDisponibles())
                {
                    // Insertar la relación en la tabla intermedia SocioActividad
                    MySqlConnection conexion = new MySqlConnection(Program.ConnectionString);
                    conexion.Open();
                    string insertQuery = "INSERT INTO SocioActividad (socioID, actividadID) VALUES (@socioID, @actividadID)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conexion);
                    insertCmd.Parameters.AddWithValue("@socioID", socioID);
                    insertCmd.Parameters.AddWithValue("@actividadID", actividadID);
                    insertCmd.ExecuteNonQuery();
                    conexion.Close();

                    // Actualizar los cupos de la actividad
                    actividad.ActualizarCupos();

                    return true;
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para esta actividad.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribir al socio: "); 
                return false;
            }
        }

        // Método para contar las actividades en las que un socio ya está inscrito
        public static int ContarActividadesInscritas(int socioID)
        {
            try
            {
                // Crear conexión a la base de datos
                MySqlConnection conexion = new MySqlConnection(Program.ConnectionString);
                conexion.Open();

                // Consulta SQL para contar el número de actividades inscritas por un socio
                string query = "SELECT COUNT(*) FROM SocioActividad WHERE socioID = @socioID";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@socioID", socioID);

                // Ejecutar la consulta y obtener el número de actividades
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al contar las actividades inscritas: " + ex.Message);
                return -1;
            }
        }

    }
}
