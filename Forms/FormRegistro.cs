using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace club_deportivo
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            btnSalir.Click += btnSalir_Click;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(); 
            menu.Show(); 
            this.Hide(); 
        }
        private void btnAltaNoSocio_Click(object sender, EventArgs e)
        {
            // Comprobar si se ha seleccionado una opción de apto físico
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Por favor, seleccione si presenta o está pendiente de apto físico.");
                return; // Salir del método si no hay selección
            }

            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text; 
            string tipoDoc = cmbDoc.SelectedItem.ToString();
            int numDoc = int.Parse(txtNumDoc.Text);
            int telefono = int.Parse(txtTelefono.Text);
            string email = txtEmail.Text;
            bool presentaAptoFisico = radioButton1.Checked;

            // Insertar el nuevo cliente en la base de datos
            int clienteId = InsertarCliente(nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico);

            if (clienteId > 0)
            {
                // Si se inserta correctamente, insertar en la tabla Socio
                InsertarSocio(clienteId);
                MessageBox.Show("Socio registrado con éxito.");
                
                FormMenu menu = new FormMenu(); 
                menu.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al registrar el socio.");
            }
        }


        private int InsertarCliente(string nombre, string apellido, string tipoDoc, int numDoc, int telefono, string email, bool presentaAptoFisico)
        {
            int clienteId = 0;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO Cliente (nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico) " +
                               "VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @telefono, @email, @presentaAptoFisico); " +
                               "SELECT LAST_INSERT_ID();"; // Para obtener el ID del nuevo cliente

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@tipoDoc", tipoDoc);
                    cmd.Parameters.AddWithValue("@numDoc", numDoc);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@presentaAptoFisico", presentaAptoFisico);

                    clienteId = Convert.ToInt32(cmd.ExecuteScalar()); // Ejecutar y obtener el clienteId
                }
            }

            return clienteId;
        }

        private void InsertarSocio(int clienteId)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO Socio (clienteID) VALUES (@clienteID);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clienteID", clienteId);
                    cmd.ExecuteNonQuery(); // Ejecutar la inserción en la tabla Socio
                }
            }
        }
    }
}
