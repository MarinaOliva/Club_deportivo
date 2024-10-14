using club_deportivo.Datos;
using System;
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
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Por favor, seleccione si presenta o está pendiente de apto físico.");
                return;
            }

            Socio nuevoSocio = new Socio
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                TipoDoc = cmbDoc.SelectedItem.ToString(),
                NumDoc = int.Parse(txtNumDoc.Text),
                Telefono = int.Parse(txtTelefono.Text),
                Email = txtEmail.Text,
                PresentaAptoFisico = radioButton1.Checked
            };

            nuevoSocio.GuardarCliente();
            nuevoSocio.GuardarSocio();
            MessageBox.Show("Socio registrado con éxito.");

            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
    }
}
