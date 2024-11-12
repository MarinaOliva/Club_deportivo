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
        private int socioId;

        public FormComprobantePago(int socioId)
        {
            InitializeComponent();
            this.socioId = socioId; // Guardamos el socioId
        }

        private void FormComprobantePago_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar los datos relacionados con el socio utilizando el socioId
            // Ejemplo de datos fijos, deberías hacer la consulta a la base de datos o servicio correspondiente

            // Cargar los datos del socio (esto debe ser reemplazado por la lógica de tu base de datos)
            string nombreSocio = "Juan Pérez";  // Reemplaza con el nombre real obtenido de la base de datos
            string dniSocio = "12345678";  // Reemplaza con el DNI real obtenido de la base de datos
            decimal valorCuota = 1500;  // Reemplaza con el valor real de la cuota
            string administrador = "Administrador1"; // Nombre del administrador que generó el comprobante

            // Asignar los valores a los controles en el formulario
            txtNombre.Text = nombreSocio;
            txtDni.Text = dniSocio;
            txtValor.Text = $"${valorCuota}";
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");  // Fecha actual
            txtAdministrador.Text = administrador;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Aquí podrías agregar el código para generar un comprobante de pago en PDF
            MessageBox.Show("Comprobante de pago generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
