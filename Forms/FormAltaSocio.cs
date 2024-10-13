using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace club_deportivo
{
    public partial class FormAltaSocio : Form
    {
        public FormAltaSocio()
        {
            InitializeComponent();

            cmbTipoDoc.Items.Add("DNI");
            cmbTipoDoc.Items.Add("Libreta de Enrolamiento");
            cmbTipoDoc.Items.Add("Pasaporte");
        }
       



        private void btnAltaSocio_Click(object sender, EventArgs e)
        {

            /* 
             if (string.IsNullOrWhiteSpace(txtNombre.Text) || 
        string.IsNullOrWhiteSpace(txtApellido.Text) || 
        cmbTipoDoc.SelectedItem == null || // Verifica que se haya seleccionado un tipo de documento
        string.IsNullOrWhiteSpace(txtNumDoc.Text) ||
        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text))
    {
        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
        return;
    }

    // Inserción de datos en la base de datos para la tabla Cliente
    string queryCliente = "INSERT INTO Cliente (nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico) VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @telefono, @email, @presentaAptoFisico)";
    
    using (MySqlCommand cmdCliente = new MySqlCommand(queryCliente, connection))
    {
        // Asigna los parámetros
        cmdCliente.Parameters.AddWithValue("@nombre", txtNombre.Text);
        cmdCliente.Parameters.AddWithValue("@apellido", txtApellido.Text);
        cmdCliente.Parameters.AddWithValue("@tipoDoc", cmbTipoDoc.SelectedItem.ToString()); // Usar el ComboBox
        cmdCliente.Parameters.AddWithValue("@numDoc", txtNumDoc.Text);
        cmdCliente.Parameters.AddWithValue("@telefono", txtTelefono.Text);
        cmdCliente.Parameters.AddWithValue("@email", txtEmail.Text);
        cmdCliente.Parameters.AddWithValue("@presentaAptoFisico", chkAptoMedico.Checked);

        try
        {
            connection.Open(); // Abre la conexión
            cmdCliente.ExecuteNonQuery(); // Ejecuta la inserción

            // Obtiene el ID del nuevo cliente insertado
            int clienteID = (int)cmdCliente.LastInsertedId;

            // Inserción en la tabla Socio
            string querySocio = "INSERT INTO Socio (clienteID, adeudaCuota, tieneCarnet) VALUES (@clienteID, @adeudaCuota, @tieneCarnet)";
            
            using (MySqlCommand cmdSocio = new MySqlCommand(querySocio, connection))
            {
                // Asigna los parámetros para la tabla Socio
                cmdSocio.Parameters.AddWithValue("@clienteID", clienteID);
                cmdSocio.Parameters.AddWithValue("@adeudaCuota", false); // Inicialmente no adeuda
                cmdSocio.Parameters.AddWithValue("@tieneCarnet", false); // Inicialmente no tiene carnet

                cmdSocio.ExecuteNonQuery(); // Ejecuta la inserción en Socio
            }

            MessageBox.Show("Socio registrado exitosamente!");
            this.Close(); // Cierra el formulario después de guardar
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al registrar socio: " + ex.Message);
        }
        finally
        {
            connection.Close(); // Asegúrate de cerrar la conexión
        }
             */
        }
    }
}
