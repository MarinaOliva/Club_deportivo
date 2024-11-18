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
using club_deportivo.Datos;


namespace club_deportivo.Forms
{
    public partial class FormConsultarCuotasVencidas : Form
    {
        public FormConsultarCuotasVencidas()
        {
            InitializeComponent();
        }

        // Cargar cuotas vencidas en el DataGridView
        public void CargarCuotasVencidas()
        {
            try
            {
                // Obtener las cuotas vencidas usando el método de la clase Cuotas
                List<Cuotas> cuotasVencidas = Cuotas.ObtenerCuotasVencidas();

                // Verificar que hay datos para mostrar
                if (cuotasVencidas.Count > 0)
                {
                    // Limpiar cualquier dato anterior en el DataGridView
                    dgvCuotasVencidas.Rows.Clear();

                    // Si las columnas no están definidas previamente, agregarlas manualmente
                    dgvCuotasVencidas.Columns.Clear();  // Limpiar las columnas si ya hay alguna definida
                    dgvCuotasVencidas.Columns.Add("socioID", "ID Socio");
                    dgvCuotasVencidas.Columns.Add("nombre", "Nombre");
                    dgvCuotasVencidas.Columns.Add("apellido", "Apellido");
                    dgvCuotasVencidas.Columns.Add("fechaVencimiento", "Fecha Vencimiento");
                    dgvCuotasVencidas.Columns.Add("importe", "Importe");

                    // Recorrer la lista de cuotas vencidas y agregar las filas al DataGridView
                    foreach (Cuotas cuota in cuotasVencidas)
                    {
                        dgvCuotasVencidas.Rows.Add(
                            cuota.SocioID,
                            cuota.Nombre,
                            cuota.Apellido,
                            cuota.FechaVencimiento.ToString("dd/MM/yyyy"),  // Formato de fecha
                            cuota.Importe.ToString("C")  // Formato de importe
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las cuotas vencidas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Evento de carga del formulario
        private void FormCuotasVencidas_Load(object sender, EventArgs e)
        {
            // Cargar las cuotas vencidas cuando el formulario se cargue
            CargarCuotasVencidas();
        }

        // Evento del botón Volver al menú principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario de cuotas vencidas y volver al formulario principal
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Ocultar el botón de impresión durante el proceso para que no aparezca en la impresión
            btnPrint.Visible = false;

            // Crear el objeto PrintDocument
            PrintDocument pd = new PrintDocument();

            // Definir los márgenes de la página
            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

            // Asociar el evento PrintPage con el método de impresión
            pd.PrintPage += (s, ev) =>
            {
                // Definir las fuentes y colores
                Font titleFont = new Font("Segoe UI", 16F, FontStyle.Bold);
                Font dataFont = new Font("Segoe UI", 10F, FontStyle.Regular);
                Brush titleBrush = Brushes.Black;
                Brush dataBrush = Brushes.Black;

                // Calcular el ancho total de la tabla (sumando los anchos de las columnas)
                int tableWidth = 100 + 150 + 150 + 180 + 120; // Suma de los anchos de las columnas
                int tableX = 20; // Posición inicial en X para la tabla
                int tableEndX = tableX + tableWidth;

                // Dibujar el fondo del título
                ev.Graphics.FillRectangle(Brushes.LightCoral, tableX, 12, tableWidth, 68);

                // Centrar el título
                string titulo = "Cuotas Vencidas";
                SizeF tituloSize = ev.Graphics.MeasureString(titulo, titleFont);
                float tituloX = tableX + (tableWidth - tituloSize.Width) / 2; // Centrado en el ancho del fondo
                ev.Graphics.DrawString(titulo, titleFont, titleBrush, tituloX, 20);

                // Posición inicial para los datos
                int yPosition = 120; // Comienza debajo del título

                // Dibujar las cabeceras de la tabla
                ev.Graphics.DrawString("ID Socio", dataFont, dataBrush, tableX, yPosition);
                ev.Graphics.DrawString("Nombre", dataFont, dataBrush, tableX + 100, yPosition);
                ev.Graphics.DrawString("Apellido", dataFont, dataBrush, tableX + 250, yPosition);
                ev.Graphics.DrawString("Fecha Vencimiento", dataFont, dataBrush, tableX + 400, yPosition);
                ev.Graphics.DrawString("Importe", dataFont, dataBrush, tableX + 580, yPosition);

                // Ajustar la posición para los datos
                yPosition += 30;

                // Recorrer las filas del DataGridView y dibujarlas
                foreach (DataGridViewRow row in dgvCuotasVencidas.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string socioID = row.Cells["socioID"].Value.ToString();
                        string nombre = row.Cells["nombre"].Value.ToString();
                        string apellido = row.Cells["apellido"].Value.ToString();
                        string fechaVencimiento = row.Cells["fechaVencimiento"].Value.ToString();
                        string importe = row.Cells["importe"].Value.ToString();

                        ev.Graphics.DrawString(socioID, dataFont, dataBrush, tableX, yPosition);
                        ev.Graphics.DrawString(nombre, dataFont, dataBrush, tableX + 100, yPosition);
                        ev.Graphics.DrawString(apellido, dataFont, dataBrush, tableX + 250, yPosition);
                        ev.Graphics.DrawString(fechaVencimiento, dataFont, dataBrush, tableX + 400, yPosition);
                        ev.Graphics.DrawString(importe, dataFont, dataBrush, tableX + 580, yPosition);

                        yPosition += 25;

                        if (yPosition > ev.MarginBounds.Bottom)
                        {
                            ev.HasMorePages = true;
                            return;
                        }
                    }
                }

                ev.HasMorePages = false;
            };

            // Mostrar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

            // Mensaje de éxito
            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}