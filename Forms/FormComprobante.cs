using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace club_deportivo.Forms
{
    public partial class FormComprobante : Form
    {
        public FormComprobante(string nombre, string dni, decimal monto, DateTime fechaPago)
        {
            InitializeComponent();

            // Concatenar los valores con el texto original de las etiquetas
            lblNombre.Text = $"Nombre: {nombre}";
            lblDNI.Text = $"DNI: {dni}";
            lblMonto.Text = $"Monto: {monto.ToString("C")}"; // Formatea el monto como moneda
            lblFecha.Text = $"Fecha de Pago: {fechaPago:dd/MM/yyyy}";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Ocultar el botón de impresión durante el proceso para que no aparezca en la impresión
            btnPrint.Visible = false;

            // Crear el objeto PrintDocument
            PrintDocument pd = new PrintDocument();

            // Asociar el evento PrintPage con el método de impresión
            pd.PrintPage += (s, ev) =>
            {
                // Dibujar el fondo (opcional)
                ev.Graphics.Clear(Color.White);

                // Dibujar el título (pnlTitulo)
                Font titleFont = new Font("Segoe UI", 20.2F, FontStyle.Bold);
                Brush titleBrush = Brushes.Black;
                ev.Graphics.FillRectangle(Brushes.Moccasin, 39, 12, 733, 68); // Fondo del título
                ev.Graphics.DrawString("Comprobante de Pago", titleFont, titleBrush, 176, 20);

                // Dibujar el logo (picLogo)
                Image logo = picLogo.Image;
                ev.Graphics.DrawImage(logo, 544, 112, 228, 213); // Ajustar la posición y tamaño según sea necesario

                // Dibujar los datos del cliente (panel1)
                Font labelFont = new Font("Segoe UI", 12, FontStyle.Regular);
                Brush labelBrush = Brushes.Black;

                ev.Graphics.DrawString("Nombre: " + lblNombre.Text, labelFont, labelBrush, 20, 120);
                ev.Graphics.DrawString("DNI: " + lblDNI.Text, labelFont, labelBrush, 20, 150);
                ev.Graphics.DrawString("Monto Abonado: " + lblMonto.Text, labelFont, labelBrush, 20, 180);
                ev.Graphics.DrawString("Fecha: " + lblFecha.Text, labelFont, labelBrush, 20, 210);

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
            btnPrint.Visible = true;

            // Mostrar mensaje de éxito
            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void ImprimirComprobante(object sender, PrintPageEventArgs e)
        {
            // Configurar las coordenadas para el dibujo
            int x = 100;
            int y = 100;

            // Dibujar las etiquetas de texto sobre el documento
            e.Graphics.DrawString(lblNombre.Text, new Font("Arial", 12), Brushes.Black, x, y);
            y += 30; // Espaciado entre líneas
            e.Graphics.DrawString(lblDNI.Text, new Font("Arial", 12), Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString(lblMonto.Text, new Font("Arial", 12), Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString(lblFecha.Text, new Font("Arial", 12), Brushes.Black, x, y);
        }

    }


}
