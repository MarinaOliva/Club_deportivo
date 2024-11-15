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
    public partial class FormComprobante : Form
    {
        public FormComprobante(string nombre, string dni, decimal monto, DateTime fechaPago)
        {
            InitializeComponent();

            // Asigna los valores a los controles del formulario
            lblNombre.Text = nombre;
            lblDNI.Text = dni;
            lblMonto.Text = monto.ToString("C"); // Formatea el monto como moneda
            lblFecha.Text = fechaPago.ToString("dd/MM/yyyy");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para imprimir el comprobante si es necesario
        }
    }


}
