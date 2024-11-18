using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
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
                    /* Para depurar
                    MessageBox.Show($"Cliente Guardado: {Nombre} {Apellido}, ID: {ClienteID}");
                    */
                }
            }
        }

        // Método para cargar los datos del cliente desde la base de datos
        protected void CargarClientePorId(int clienteId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
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

                                /* Para depurar
                                MessageBox.Show($"Cliente cargado: {Nombre} {Apellido}, ID: {ClienteID}");
                                */
                                }
                            else
                            {
                                throw new Exception("Cliente no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cliente: {ex.Message}");
            }
        }

        // Método para generar el comprobante de pago
        public (string nombre, string dni, decimal monto, DateTime fechaPago) ObtenerComprobante(int socioId)
        {
            string nombreCompleto = string.Empty;
            string dni = string.Empty;
            decimal importe = 0;
            DateTime fechaPago = DateTime.MinValue;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString ))
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
                                dni = reader.GetInt32("numDoc").ToString();
                                importe = reader.GetDecimal("importe");
                                fechaPago = reader.GetDateTime("fechaPago");
                                /* Para depurar
                                MessageBox.Show($"Comprobante generado: {nombreCompleto}, {dni}, {importe}, {fechaPago}");
                                */
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener comprobante: {ex.Message}");
            }

            return (nombreCompleto, dni, importe, fechaPago);
        }
    }
}
