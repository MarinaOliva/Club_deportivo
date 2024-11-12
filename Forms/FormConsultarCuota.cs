using club_deportivo.Datos;
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
    public partial class FormConsultarCuota : Form
    {
        public FormConsultarCuota()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            int? socioId = null;
            int? dni = null;

            // Verifica si el usuario ingresó un número de socio o un DNI
            if (int.TryParse(txtNumeroSocio.Text, out int result))
            {
                socioId = result;
            }
            else if (int.TryParse(txtDNI.Text, out result))
            {
                dni = result;
            }

            // Llama al método con los valores disponibles
            var cuota = Cuotas.ObtenerCuotaPorSocioODNI(socioId, dni);

            if (cuota != null)
            {
                // Si encontró el socio, abre el formulario para abonar la cuota
                FormAbonarCuota formularioAbono = new FormAbonarCuota();

                // Pasa los datos relevantes al formulario AbonarCuota
                formularioAbono.SocioID = cuota.SocioID;  // Pasa el SocioID o cualquier otro dato relevante

                // Abre el formulario
                formularioAbono.Show();
            }
            else
            {
                // Si no se encontró el socio, muestra el mensaje de error
                MessageBox.Show("Socio no encontrado. Verifique el dato ingresado e intente nuevamente",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
