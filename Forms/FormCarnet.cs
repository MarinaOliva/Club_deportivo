using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace club_deportivo.Forms
{
    public partial class FormCarnet : Form
    {
        public FormCarnet(string nombre, string apellido, string numeroSocio)
        {
            InitializeComponent();

            // Mostrar los datos del socio en los labels correspondientes
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblNumSocio.Text = numeroSocio;
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Ocultar el botón de impresión durante el proceso para que no aparezca en la impresión
            btnImprimir.Visible = false;

            // Crear el objeto PrintDocument
            PrintDocument pd = new PrintDocument();

            // Asociar el evento PrintPage con el método de impresión
            pd.PrintPage += (s, ev) =>
            {
                // Dibujar el fondo (opcional)
                ev.Graphics.Clear(Color.White);

                // Dibujar el título (lblTitulo)
                Font titleFont = new Font("Segoe UI", 20.2F, FontStyle.Bold);
                Brush titleBrush = Brushes.Black;
                ev.Graphics.FillRectangle(Brushes.LightCoral, 39, 12, 733, 68); // Fondo del título
                ev.Graphics.DrawString("Carnet de Socio", titleFont, titleBrush, 176, 20);

                // Dibujar el logo (picLogo)
                Image logo = picLogo.Image;
                ev.Graphics.DrawImage(logo, 544, 112, 228, 213); // Ajustar la posición y tamaño según sea necesario

                // Dibujar los datos del socio (lblNombre, lblApellido, lblNumSocio)
                Font labelFont = new Font("Segoe UI", 12, FontStyle.Regular);
                Brush labelBrush = Brushes.Black;

                ev.Graphics.DrawString("Nombre: " + lblNombre.Text, labelFont, labelBrush, 20, 120);
                ev.Graphics.DrawString("Apellido: " + lblApellido.Text, labelFont, labelBrush, 20, 150);
                ev.Graphics.DrawString("Número de Socio: " + lblNumSocio.Text, labelFont, labelBrush, 20, 180);

                // Evitar que la impresión continúe en una nueva página
                ev.HasMorePages = false;
            };

            // Mostrar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Imprimir el documento
                pd.Print();
            }

            // Volver a hacer visible el botón de impresión
            btnImprimir.Visible = true;

            // Mostrar mensaje de éxito
            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }

}
