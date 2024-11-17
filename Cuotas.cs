using MySql.Data.MySqlClient;
using System;

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

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    string query = "SELECT c.fechaVencimiento, c.fechaPago, c.importe, s.socioID " +
                                   "FROM Cuota c " +
                                   "JOIN Socio s ON s.socioID = c.socioID " +
                                   "WHERE s.socioID = @socioID " +
                                   "ORDER BY c.fechaVencimiento DESC " +
                                   "LIMIT 1 ";

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
                            /* Para depurar
                            MessageBox.Show($"Cuota obtenida: {cuota.Importe}, Estado: {cuota.EstadoCuota()}");
                            */
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener cuota: {ex.Message}");
            }

            return cuota;
        }

        // Método para obtener la fecha de validez de la cuota (30 días después del pago)
        public DateTime? FechaValidez()
        {
            if (FechaPago.HasValue)
            {
                return FechaPago.Value.AddDays(30);
            }
            return null;
        }

        // Método para registrar pago de cuota
        public static bool RegistrarPagoCuota(int socioId)
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    string query = "UPDATE Cuota SET fechaPago = @fechaPago WHERE socioID = @socioID AND fechaPago IS NULL";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fechaPago", DateTime.Now);
                    cmd.Parameters.AddWithValue("@socioID", socioId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    //MessageBox.Show($"Pago registrado para el socio {socioId}, filas afectadas: {rowsAffected}");
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar pago de cuota: {ex.Message}");
                return false;
            }
        }
    }
}
