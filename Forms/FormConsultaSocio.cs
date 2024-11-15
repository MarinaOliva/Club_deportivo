using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using club_deportivo.Datos;
using MySql.Data.MySqlClient;

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
            // Verifica si el carácter ingresado no es un número y no es un control (como Backspace)
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

                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Primera consulta para verificar si el número de documento existe en Cliente
                    string queryDocumento = "SELECT * FROM Cliente WHERE numDoc = @numero";
                    MySqlCommand cmdDocumento = new MySqlCommand(queryDocumento, conn);
                    cmdDocumento.Parameters.AddWithValue("@numero", numeroDocumento);

                    MySqlDataReader readerDoc = cmdDocumento.ExecuteReader();

                    if (readerDoc.HasRows)
                    {
                        readerDoc.Read();
                        // Verificar si el tipo de documento coincide
                        if (readerDoc["tipoDoc"].ToString() != tipoDocSeleccionado)
                        {
                            MessageBox.Show("El tipo de documento no coincide con el número ingresado. Verifique los datos.");
                            readerDoc.Close();
                            return; // Detener la ejecución aquí si el tipo de documento no coincide
                        }
                        readerDoc.Close();

                        // Consulta en Socio para verificar que el cliente sea socio
                        string querySocio = @"
                    SELECT *
                    FROM Socio AS s
                    JOIN Cliente AS c ON s.clienteID = c.clienteID
                    WHERE c.numDoc = @numero AND c.tipoDoc = @tipo";
                        MySqlCommand cmdSocio = new MySqlCommand(querySocio, conn);
                        cmdSocio.Parameters.AddWithValue("@numero", numeroDocumento);
                        cmdSocio.Parameters.AddWithValue("@tipo", tipoDocSeleccionado);

                        MySqlDataReader readerSocio = cmdSocio.ExecuteReader();
                        if (readerSocio.HasRows)
                        {
                            readerSocio.Read();
                            FormInfoSocio formInfo = new FormInfoSocio(this.Owner as FormMenu);
                            formInfo.LoadData(readerSocio);
                            this.Hide();
                            formInfo.Show();
                        }
                        else
                        {
                            MessageBox.Show("El cliente no es un socio registrado.");
                            FormNoSocio formNoSocio = new FormNoSocio(numeroDocumento);
                            this.Hide();
                            formNoSocio.Show();
                        }
                        readerSocio.Close();
                    }
                    else
                    {
                        MessageBox.Show("El número de documento no existe. Puede registrar un nuevo cliente.");
                        FormNoSocio formNoSocio = new FormNoSocio(numeroDocumento);
                        this.Hide();
                        formNoSocio.Show();
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

        }
    }
}
