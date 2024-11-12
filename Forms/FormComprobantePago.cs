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
    public partial class FormComprobantePago : Form
    {
        public FormComprobantePago()
        {
            InitializeComponent();
        }

        private void FormComprobantePago_Load(object sender, EventArgs e)
        {
            // Inicializa el formulario con los datos necesarios
            txtNombre.Text = "Juan Pérez"; // Ejemplo de nombre
            txtDni.Text = "12345678"; // Ejemplo de DNI
            txtValor.Text = "$1500"; // Ejemplo de valor
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Fecha actual
            txtAdministrador.Text = "Administrador1"; // Nombre del administrador
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Aquí podrías agregar el código para generar un comprobante de pago en PDF
            MessageBox.Show("Comprobante de pago generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

