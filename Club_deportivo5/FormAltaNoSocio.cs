using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace club_Deportivo
{
    public partial class FormAltaNoSocio : Form
    {
        public FormAltaNoSocio()
        {
            InitializeComponent();


            cmbTipoDoc.Items.Add("DNI");
            cmbTipoDoc.Items.Add("Libreta de Enrolamiento");
            cmbTipoDoc.Items.Add("Pasaporte");


            cmbActividad.Items.Add("Fútbol");
            cmbActividad.Items.Add("Tenis");
            cmbActividad.Items.Add("Natación");
            cmbActividad.Items.Add("Musculatura");
        }

        private void btnAltaNoSocio_Click(object sender, EventArgs e)
        {
            /*
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        cmbTipoDoc.SelectedItem == null ||
        string.IsNullOrWhiteSpace(txtNumDoc.Text) ||
        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        cmbActividad.SelectedItem == null) // Verifica que se haya seleccionado una actividad
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            // Inserción de datos en la base de datos para la tabla Cliente
            string queryCliente = "INSERT INTO Cliente (nombre, apellido, tipoDoc, numDoc, telefono, email) VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @telefono, @email)";

            using (MySqlCommand cmdCliente = new MySqlCommand(queryCliente, connection))
            {
                // Asigna los parámetros
                cmdCliente.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmdCliente.Parameters.AddWithValue("@apellido", txtApellido.Text);
                cmdCliente.Parameters.AddWithValue("@tipoDoc", cmbTipoDoc.SelectedItem.ToString()); // Usar el ComboBox
                cmdCliente.Parameters.AddWithValue("@numDoc", txtNumDoc.Text);
                cmdCliente.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmdCliente.Parameters.AddWithValue("@email", txtEmail.Text);

                try
                {
                    connection.Open(); // Abre la conexión
                    cmdCliente.ExecuteNonQuery(); // Ejecuta la inserción

                    // Obtiene el ID del nuevo cliente insertado
                    int clienteID = (int)cmdCliente.LastInsertedId;

                    // Inserción en la tabla NoSocio
                    string queryNoSocio = "INSERT INTO NoSocio (clienteID) VALUES (@clienteID)";

                    using (MySqlCommand cmdNoSocio = new MySqlCommand(queryNoSocio, connection))
                    {
                        // Asigna el clienteID
                        cmdNoSocio.Parameters.AddWithValue("@clienteID", clienteID);
                        cmdNoSocio.ExecuteNonQuery(); // Ejecuta la inserción en NoSocio
                    }

                    // Puedes agregar lógica aquí para registrar la actividad si es necesario

                    MessageBox.Show("No socio registrado exitosamente!");
                    this.Close(); // Cierra el formulario después de guardar
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar no socio: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Asegúrate de cerrar la conexión
                }
                */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
