using System;
using System.Windows.Forms;

namespace club_Deportivo
{
    public partial class FormLogin : Form
    {
        private MySqlConnection connection;
        public FormLogin()
        {
            InitializeComponent();
            
            // Inicializa la cadena de conexión
            string connectionString = "Server=localhost;Database=Proyecto;User ID=root;Password=;";
            connection = new MySqlConnection(connectionString);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* Cadena de consulta para verificar las credenciales
            string query = "CALL IngresoLogin(@usuarioNombre, @usuarioContrasena)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@usuarioNombre", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@usuarioContrasena", txtContrasena.Text);

                try
                {
                    connection.Open(); // Abre la conexión

                    // Ejecuta la consulta
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login exitoso!");

                        // Oculta el formulario de login
                        this.Hide();

                        // Crea una nueva instancia del formulario de menú
                        FormMenu formMenu = new FormMenu();
                        formMenu.Show(); // Muestra el formulario de menú
                    }
                    else
                    {
                        // Muestra un mensaje de error si las credenciales son incorrectas
                        MessageBox.Show("Usuario y/o contraseña incorrectos. Intente nuevamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar conectarse a la base de datos: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
            }*/
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear(); // Limpiar el TextBox del usuario
            txtContrasena.Clear(); // Limpiar el TextBox de la contraseña
        }

    }
}
