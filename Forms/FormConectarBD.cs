using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace club_deportivo.Forms
{
    public partial class FormConectarBD : Form
    {
        private string connectionString;

        public FormConectarBD()
        {
            InitializeComponent();
            connectionString = "default connection string";

        }

        private void btnConectar_1_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string baseDatos = txtBaseDatos.Text;

            string cadenaConexion = $"Server={host};Port={puerto};Database={baseDatos};Uid={usuario};Pwd={contraseña};";

            try
            {
                // Probar la conexión
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guardar la conexión para usarla en la aplicación
                    Program.ConnectionString = cadenaConexion;
                    MessageBox.Show("La conexión se ha configurado correctamente y está lista para ser utilizada.", "Conexión lista", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Cerrar este formulario y pasar al siguiente
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
