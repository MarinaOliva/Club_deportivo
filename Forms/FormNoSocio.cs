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
    public partial class FormNoSocio : Form
    {
        private int numeroDocumento;

        public FormNoSocio(int numeroDocumento)
        {
            InitializeComponent();
            this.numeroDocumento = numeroDocumento;
            label_dniIng.Text = $"N° de documento ingresado: {numeroDocumento}";

            btn_Asociar.Click += Btn_Asociar_Click;
            btn_Act.Click += Btn_Act_Click;
        }
        private void Btn_Asociar_Click(object? sender, EventArgs e)
        {
            FormRegistro formAltaNoSocio = new FormRegistro();
            this.Hide(); 
            formAltaNoSocio.Show();
        }

        private void Btn_Act_Click(object? sender, EventArgs e)
        {
            FormActividad formActividad = new FormActividad();
            this.Hide(); 
            formActividad.Show(); 
        }
    }
}

