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

        public static Cuotas ObtenerCuotaPorSocioODNI(int? socioId = null, int? dni = null)
        {
            Cuotas cuota = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                // Construye la consulta basada en los parámetros disponibles
                string query = "SELECT c.fechaVencimiento, c.fechaPago, s.socioID FROM Cuota c ";
                query += "JOIN Socio s ON s.socioID = c.socioID ";
                query += "JOIN Cliente cl ON s.clienteID = cl.clienteID ";
                query += "WHERE ";

                // Si socioId se pasa, se filtra por socioID
                if (socioId.HasValue)
                {
                    query += "s.socioID = @socioID";
                }
                // Si dni se pasa, se filtra por numDoc de la tabla Cliente
                if (dni.HasValue)
                {
                    if (socioId.HasValue)
                    {
                        query += " OR ";
                    }
                    query += "cl.numDoc = @dni";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Agrega los parámetros a la consulta
                if (socioId.HasValue)
                {
                    cmd.Parameters.AddWithValue("@socioID", socioId.Value);
                }
                if (dni.HasValue)
                {
                    cmd.Parameters.AddWithValue("@dni", dni.Value);
                }

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cuota = new Cuotas
                        {
                            SocioID = reader.GetInt32("socioID"), // Obtiene el socioID desde la consulta
                            FechaVencimiento = reader.GetDateTime("fechaVencimiento"),
                            FechaPago = reader["fechaPago"] != DBNull.Value ? (DateTime?)reader.GetDateTime("fechaPago") : null
                        };
                    }
                }
            }

            return cuota;
        }


    }
}
