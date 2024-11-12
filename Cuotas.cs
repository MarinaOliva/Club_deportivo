using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace club_deportivo.Datos
{
    public class Cuotas
    {
        public int SocioID { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaPago { get; set; }
        public decimal Importe { get; set; }

        // Método para determinar el estado de la cuota
        public string EstadoCuota()
        {
            if (FechaPago.HasValue)
            {
                return "Pagada";
            }
            else if (FechaVencimiento < DateTime.Now)
            {
                return "Vencida";
            }
            else
            {
                return "Pendiente";
            }
        }

        // Método estático para obtener la cuota de un socio usando solo el número de socio
        public static Cuotas ObtenerCuotaPorSocio(int socioId)
        {
            Cuotas cuota = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                // Consulta SQL solo con filtro por socioID
                string query = "SELECT c.fechaVencimiento, c.fechaPago, c.importe, s.socioID " +
                               "FROM Cuota c " +
                               "JOIN Socio s ON s.socioID = c.socioID " +
                               "WHERE s.socioID = @socioID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@socioID", socioId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cuota = new Cuotas
                        {
                            SocioID = reader.GetInt32("socioID"),
                            FechaVencimiento = reader.GetDateTime("fechaVencimiento"),
                            FechaPago = reader["fechaPago"] != DBNull.Value ? (DateTime?)reader.GetDateTime("fechaPago") : null,
                            Importe = reader.GetDecimal("importe")
                        };
                    }
                }
            }

            return cuota;
        }
        // método para registrar pago de cuota
        public static bool RegistrarPagoCuota(int socioId, DateTime fechaPago)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                // Modifica la consulta para actualizar la fecha de pago con la fecha proporcionada por el usuario
                string query = "UPDATE Cuota SET fechaPago = @fechaPago WHERE socioID = @socioID AND fechaPago IS NULL";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@socioID", socioId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Retorna true si se actualizó alguna fila
            }
        }


    }
}
