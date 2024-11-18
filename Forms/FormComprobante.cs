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
        // Dibujar el fondo del formulario (pnlComp)
        Brush formBackgroundBrush = new SolidBrush(pnlComp.BackColor);
        ev.Graphics.FillRectangle(formBackgroundBrush, 21, 12, 767, 390);

        // Dibujar el encabezado (pnlTitulo) con color de fondo
        ev.Graphics.FillRectangle(Brushes.Teal, 39, 12, 733, 68); // Fondo del título
        Font titleFont = new Font("Segoe UI", 20.2F, FontStyle.Bold);
        Brush titleBrush = Brushes.OrangeRed;
        ev.Graphics.DrawString(label1.Text, titleFont, titleBrush, 176, 20);

        // Dibujar el fondo del panel de contenido (pnlContenido)
        ev.Graphics.FillRectangle(Brushes.Black, 39, 86, 422, 288);

        // Dibujar los datos del socio (lblNombre, lblDNI, lblMonto, lblFecha) con su respectivo color y fuente
        Font labelFont = new Font("Segoe UI", 10.2F, FontStyle.Bold);
        Brush labelBrush = Brushes.Red;

        ev.Graphics.DrawString(lblNombre.Text, labelFont, labelBrush, 60, 120);
        ev.Graphics.DrawString(lblDNI.Text, labelFont, labelBrush, 60, 170);
        ev.Graphics.DrawString(lblMonto.Text, labelFont, labelBrush, 60, 210);
        ev.Graphics.DrawString(lblFecha.Text, labelFont, labelBrush, 60, 250);

        // Dibujar el logo (picLogo)
        if (picLogo.Image != null)
        {
            ev.Graphics.DrawImage(picLogo.Image, 400, 20, 428, 413);
        }

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




        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void FormComprobante_Load(object sender, EventArgs e)
        {

        }
    }


}
