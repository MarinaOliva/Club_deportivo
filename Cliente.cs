using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace club_deportivo
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDoc { get; set; }
        public int NumDoc { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public bool PresentaAptoFisico { get; set; }

        // Constructor para cargar los datos del cliente desde la base de datos
        public Cliente(int clienteId)
        {
            CargarClientePorId(clienteId);
        }
        public Cliente() { }

        // Método para guardar un nuevo cliente en la base de datos
        public void GuardarCliente()
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO Cliente (nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico) " +
                               "VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @telefono, @email, @presentaAptoFisico); " +
                               "SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@apellido", Apellido);
                    cmd.Parameters.AddWithValue("@tipoDoc", TipoDoc);
                    cmd.Parameters.AddWithValue("@numDoc", NumDoc);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@presentaAptoFisico", PresentaAptoFisico);
                    ClienteID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        // Método para cargar los datos del cliente desde la base de datos
        private void CargarClientePorId(int clienteId)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "SELECT nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico FROM Cliente WHERE ClienteID = @clienteID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clienteID", clienteId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Nombre = reader.GetString("nombre");
                            Apellido = reader.GetString("apellido");
                            TipoDoc = reader.GetString("tipoDoc");
                            NumDoc = reader.GetInt32("numDoc");
                            Telefono = reader.GetInt32("telefono");
                            Email = reader.GetString("email");
                            PresentaAptoFisico = reader.GetBoolean("presentaAptoFisico");
                        }
                        else
                        {
                            // Si no se encuentra el cliente, lanzar una excepción o manejar el error según sea necesario
                            throw new Exception("Cliente no encontrado.");
                        }
                    }
                }
            }
        }

        // Método para generar el comprobante de pago
        public (string nombre, string dni, decimal monto, DateTime fechaPago) ObtenerComprobante(int socioId)
        {
            string nombreCompleto = string.Empty;
            string dni = string.Empty;
            decimal importe = 0;
            DateTime fechaPago = DateTime.MinValue;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                string query = @"SELECT CONCAT(c.nombre, ' ', c.apellido) AS nombreCompleto, c.numDoc, q.importe, q.fechaPago
                         FROM Cliente c
                         JOIN Socio s ON c.ClienteID = s.ClienteID
                         JOIN Cuota q ON s.socioID = q.socioID
                         WHERE s.socioID = @socioId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@socioId", socioId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreCompleto = reader.GetString("nombreCompleto");
                            dni = reader.GetInt32("numDoc").ToString(); // Convertir el DNI a string
                            importe = reader.GetDecimal("importe");
                            fechaPago = reader.GetDateTime("fechaPago");
                        }
                    }
                }
            }

            return (nombreCompleto, dni, importe, fechaPago); // Devuelve todos los datos en una tupla
        }
    }
}


