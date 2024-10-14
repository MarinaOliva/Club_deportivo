using club_deportivo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace club_deportivo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnVolver_Login_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void btnAltaNoSocio_Click(object sender, EventArgs e)
        {
            FormRegistro formAltaNoSocio = new FormRegistro();
            formAltaNoSocio.ShowDialog();
        }

        private void RegistrarCliente_Click(object sender, EventArgs e)
        {
            FormConsultaSocio formConsultaSocio = new FormConsultaSocio();
            formConsultaSocio.Owner = this;
            formConsultaSocio.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*string query = "SELECT c.nombre, c.apellido, cu.fechaVencimiento FROM Cuota cu JOIN Socio s ON cu.socioID = s.socioID JOIN Cliente c ON s.clienteID = c.clienteID WHERE cu.fechaVencimiento = CURDATE()";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                connection.Open(); // Abre la conexión
                var reader = cmd.ExecuteReader();
                string resultados = "Cuotas vencidas:\n";

                // Recorre los resultados de la consulta
                while (reader.Read())
                {
                    resultados += $"Nombre: {reader["nombre"]} {reader["apellido"]}, Vencimiento: {reader["fechaVencimiento"]}\n";
                }

                // Muestra los resultados en un cuadro de diálogo
                MessageBox.Show(resultados);
                connection.Close(); // Cierra la conexión
            }*/
        }
    }
}
