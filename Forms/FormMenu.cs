using club_deportivo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace club_deportivo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnVolver_Login_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void btnAltaNoSocio_Click(object sender, EventArgs e)
        {
            FormRegistro formAltaNoSocio = new FormRegistro();
            formAltaNoSocio.ShowDialog();
        }

        private void RegistrarCliente_Click(object sender, EventArgs e)
        {
            FormConsultaSocio formConsultaSocio = new FormConsultaSocio();
            formConsultaSocio.Owner = this;
            formConsultaSocio.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de FormConsultarCuota
            FormConsultarCuota formConsultarCuota = new FormConsultarCuota();

            // Muestra el formulario
            formConsultarCuota.Show();

            // Ocultar el formulario actual:
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
