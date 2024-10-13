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
            // Intentar convertir el texto ingresado a un número entero
            if (int.TryParse(numero.Text, out int numeroDocumento))
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Cliente WHERE numDoc = @numero";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@numero", numeroDocumento);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        // Si existe, crea un nuevo formulario para mostrar la información
                        FormInfoSocio formInfo = new FormInfoSocio(this.Owner as FormMenu);
                        formInfo.LoadData(reader); // Método para cargar datos
                        this.Hide(); // Ocultar el formulario actual
                        formInfo.Show(); // Mostrar el nuevo formulario
                       
                    }
                    else
                    {
                      
                        // Si no existe, muestra un nuevo formulario con opciones
                        FormNoSocio formNoSocio = new FormNoSocio(numeroDocumento);
                        this.Hide();
                        formNoSocio.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de documento válido.");
            }
        } 
    } 
}
