using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Windows.Forms;

namespace club_deportivo.Forms
{
    public partial class FormActividad : Form
    {
        public FormActividad()
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

        private void label2_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }
    }
}