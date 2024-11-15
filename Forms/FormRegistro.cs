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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar campos de texto
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;

            // Restablecer el ComboBox a su estado inicial (sin selección)
            cmbDoc.SelectedIndex = -1;

            // Restablecer la fecha del DateTimePicker al valor actual
            dateTimePicker1.Value = DateTime.Now;

            // Deseleccionar los RadioButton
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
