using club_deportivo.Datos;
using System;
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
            if (int.TryParse(txtNumeroSocio.Text, out int socioId))
            {
                // Llama al método usando solo el número de socio
                var cuota = Cuotas.ObtenerCuotaPorSocio(socioId);

                if (cuota != null)
                {
                    // Si encontró el socio, abre el formulario para abonar la cuota
                    FormAbonarCuota formularioAbono = new FormAbonarCuota(socioId);

                    this.Hide();

                    // Abre el formulario
                    formularioAbono.ShowDialog(); // Usa ShowDialog para abrirlo como modal
                }
                else
                {
                    // Si no se encontró el socio, muestra el mensaje de error
                    MessageBox.Show("Socio no encontrado. Verifique el número de socio ingresado e intente nuevamente",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Muestra un mensaje de error si el número de socio no es válido
                MessageBox.Show("Ingrese un número de socio válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormConsultarCuota_Load(object sender, EventArgs e)
        {
            // Puedes realizar cualquier configuración adicional al cargar el formulario aquí.
        }
    }
}
