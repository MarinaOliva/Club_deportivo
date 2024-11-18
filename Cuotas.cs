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
        public string Nombre { get; set; }
        public string Apellido { get; set; }

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
                using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT c.fechaVencimiento, c.fechaPago, c.importe, s.socioID, cl.nombre, cl.apellido " +
                                   "FROM Cuota c " +
                                   "JOIN Socio s ON s.socioID = c.socioID " +
                                   "JOIN Cliente cl ON s.clienteID = cl.clienteID " +  // Unir con Cliente para obtener nombre y apellido
                                   "WHERE s.socioID = @socioID " +
                                   "ORDER BY c.fechaVencimiento DESC " +
                                   "LIMIT 1";

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
                                Importe = reader.GetDecimal("importe"),
                                Nombre = reader.GetString("nombre"),  // Obtener el nombre del socio
                                Apellido = reader.GetString("apellido")  // Obtener el apellido del socio
                            };
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
                using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
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

        // Método para listar todas las cuotas vencidas
        public static List<Cuotas> ObtenerCuotasVencidas()
        {
            List<Cuotas> listaCuotas = new List<Cuotas>();
        
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString ))
                {
                    conn.Open();
                   
                    string query = @"
                        SELECT 
                            s.socioID, 
                            cl.nombre, 
                            cl.apellido, 
                            cu.fechaVencimiento, 
                            cu.importe
                        FROM 
                            Cuota cu
                        INNER JOIN 
                            Socio s ON cu.socioID = s.socioID
                        INNER JOIN 
                            Cliente cl ON s.clienteID = cl.clienteID
                        WHERE 
                            cu.fechaVencimiento < CURDATE() 
                            AND cu.fechaPago IS NULL";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuotas cuota = new Cuotas
                            {
                                SocioID = reader.GetInt32("socioID"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                FechaVencimiento = reader.GetDateTime("fechaVencimiento"),
                                Importe = reader.GetDecimal("importe"),
                                FechaPago = null // No se requiere ya que son cuotas vencidas
                            };
                            listaCuotas.Add(cuota);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener cuotas vencidas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaCuotas;
        }
    }
}
