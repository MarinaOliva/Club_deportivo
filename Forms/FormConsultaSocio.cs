using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using club_deportivo.Datos;

namespace club_deportivo.Forms
{
    public partial class FormConsultaSocio : Form
    {
        public FormConsultaSocio()
        {
            InitializeComponent();
            Consulta.Click += Consulta_Click;
            numero.KeyPress += numero_KeyPress;
        }

        // Evento KeyPress para validar que solo se ingresen números
        private void numero_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el ingreso del carácter
            }
        }

        private void Consulta_Click(object? sender, EventArgs e)
        {
            if (int.TryParse(numero.Text, out int numeroDocumento) && cmbTipoDoc.SelectedItem != null)
            {
                string tipoDocSeleccionado = cmbTipoDoc.SelectedItem.ToString();

                /* Depuración: Verificar el valor de numeroDocumento
                MessageBox.Show($"Número de documento ingresado: {numeroDocumento}");
                */
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Declarar clienteId fuera del bloque using para evitar el error de ámbito
                    int clienteId = 0;

                    // Primera consulta para verificar si el número de documento existe en Cliente
                    string queryDocumento = "SELECT * FROM Cliente WHERE numDoc = @numero";
                    MySqlCommand cmdDocumento = new MySqlCommand(queryDocumento, conn);
                    cmdDocumento.Parameters.AddWithValue("@numero", numeroDocumento);

                    using (MySqlDataReader readerDoc = cmdDocumento.ExecuteReader())
                    {
                        if (readerDoc.HasRows)
                        {
                            readerDoc.Read();

                            /* Depuración: Verificar el valor obtenido
                             * de numDoc desde la base de datos
                            int numDocEnBD = readerDoc.GetInt32(readerDoc.GetOrdinal("numDoc"));
                            MessageBox.Show($"Número de documento desde la base de datos: {numDocEnBD}");
                            */

                            // Verificar si el tipo de documento coincide
                            if (readerDoc["tipoDoc"].ToString() != tipoDocSeleccionado)
                            {
                                MessageBox.Show("El tipo de documento no coincide con el número ingresado. Verifique los datos.");
                                return;
                            }

                            // Obtener el clienteID
                            clienteId = Convert.ToInt32(readerDoc["clienteID"]);
                            //MessageBox.Show($"ClienteID obtenido: {clienteId}");
                        }
                        else
                        {
                            MessageBox.Show("El número de documento no existe. Puede registrar un nuevo cliente.");
                            FormNoSocio formNoSocio = new FormNoSocio(numeroDocumento, this.Owner as FormMenu);
                            this.Hide();
                            formNoSocio.Show();
                            return;
                        }
                    }

                    // Consulta en Socio para verificar que el cliente sea socio usando clienteId
                    string querySocio = @"
                    SELECT s.*, c.nombre, c.apellido, c.numDoc, c.tipoDoc
                    FROM Socio AS s
                    JOIN Cliente AS c ON s.clienteID = c.clienteID
                    WHERE s.clienteID = @clienteId";
                    MySqlCommand cmdSocio = new MySqlCommand(querySocio, conn);
                    cmdSocio.Parameters.AddWithValue("@clienteId", clienteId);

                    using (MySqlDataReader readerSocio = cmdSocio.ExecuteReader())
                    {
                        if (readerSocio.HasRows)
                        {
                            readerSocio.Read();

                            // Crear una instancia de Socio usando los datos obtenidos del MySqlDataReader
                            Socio socio = new Socio
                            {
                                SocioID = Convert.ToInt32(readerSocio["socioID"]),
                                ClienteID = Convert.ToInt32(readerSocio["clienteID"]),
                                Nombre = readerSocio["nombre"].ToString(),
                                Apellido = readerSocio["apellido"].ToString(),
                                NumDoc = readerSocio.GetInt32(readerSocio.GetOrdinal("numDoc")),
                                TipoDoc = readerSocio["tipoDoc"].ToString()
                            };

                            /* Depuración: Verificar los datos recibidos
                            MessageBox.Show($"Cargando datos para: {socio.Nombre} {socio.Apellido}, N° Documento: {socio.NumDoc}, Tipo de Documento: {socio.TipoDoc}");
                            */

                            // Llamar al método de la clase Socio para cargar la información (cuotas y actividades)
                            socio.CargarInformacionSocio();

                            /* Depuración: Verificar la información cargada
                            MessageBox.Show($"Socio encontrado: {socio.Nombre} {socio.Apellido}");
                            MessageBox.Show($"Fecha de validez: {socio.FechaValidez}");
                            */

                            Cuotas cuota = socio.Cuota;

                            // Mostrar la ventana con la información cargada
                            FormInfoSocio formInfo = new FormInfoSocio(this.Owner as FormMenu);
                            formInfo.LoadData(socio, cuota); // Llamar a LoadData con el objeto Socio
                            this.Hide();
                            formInfo.Show();
                        }
                        else
                        {
                            MessageBox.Show("El cliente no es un socio registrado.");
                            FormNoSocio formNoSocio = new FormNoSocio(numeroDocumento, this.Owner as FormMenu);
                            this.Hide();
                            formNoSocio.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de documento y seleccione el tipo de documento.");
            }
        }

        private void FormConsultaSocio_Load(object sender, EventArgs e)
        {
            // 
        }
    }
}
