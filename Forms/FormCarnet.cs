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
                // Dibujar el fondo del carnet (pnlCarnet)
                Brush carnetBackgroundBrush = new SolidBrush(pnlCarnet.BackColor);
                ev.Graphics.FillRectangle(carnetBackgroundBrush, 25, 12, 750, 420);

                // Dibujar el encabezado (pnlHeader) con color de fondo
                ev.Graphics.FillRectangle(Brushes.Teal, 39, 12, 733, 68); // Fondo del título
                Font titleFont = new Font("Segoe UI", 20.2F, FontStyle.Bold);
                Brush titleBrush = Brushes.Orange;
                ev.Graphics.DrawString("Carnet de Socio", titleFont, titleBrush, 176, 20);

                // Dibujar el fondo del panel de contenido (pnlContenido)
                ev.Graphics.FillRectangle(Brushes.Black, 39, 120, 414, 270); // Fondo de contenido

                // Dibujar los datos del socio (lblNombre, lblApellido, lblNumSocio) en color naranja
                Font labelFont = new Font("Segoe UI", 12, FontStyle.Bold); // Poner el texto en negrita
                Brush labelBrush = Brushes.Orange;

                // Dibujar el texto dentro del área correspondiente
                ev.Graphics.DrawString(lblNombre.Text, labelFont, labelBrush, 70, 160); 
                ev.Graphics.DrawString(lblApellido.Text, labelFont, labelBrush, 70, 240);
                ev.Graphics.DrawString(lblNumSocio.Text, labelFont, labelBrush, 70, 320);

                // Dibujar el logo (picLogo) ajustado al tamaño correcto y reposicionado
                Image logo = picLogo.Image;
                float logoWidth = 428f; // Ancho del logo
                float logoHeight = 413f; // Alto del logo
                float logoX = 400f; // posición X
                float logoY = 30f;  // posición Y
                ev.Graphics.DrawImage(logo, logoX, logoY, logoWidth, logoHeight); // Dibujar el logo ajustado

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
