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
                else
                {
                    MessageBox.Show("No hay cuotas vencidas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50); // Ajuste de márgenes

            // Asociar el evento PrintPage con el método de impresión
            pd.PrintPage += (s, ev) =>
            {
                // Definir la fuente para el título y los datos
                Font titleFont = new Font("Segoe UI", 16F, FontStyle.Bold);
                Font dataFont = new Font("Segoe UI", 10F, FontStyle.Regular);
                Brush titleBrush = Brushes.Black;
                Brush dataBrush = Brushes.Black;

                // Título
                ev.Graphics.FillRectangle(Brushes.LightCoral, 39, 12, 733, 68); // Fondo del título
                ev.Graphics.DrawString("Cuotas Vencidas", titleFont, titleBrush, 176, 20);

                // Definir la posición inicial para los datos
                int yPosition = 120; // Comienza debajo del título

                // Definir el ancho de las columnas
                int columnWidth1 = 100; // Ancho para la columna "ID Socio"
                int columnWidth2 = 150; // Ancho para la columna "Nombre"
                int columnWidth3 = 150; // Ancho para la columna "Apellido"
                int columnWidth4 = 180; // Ancho para la columna "Fecha Vencimiento"
                int columnWidth5 = 120; // Ancho para la columna "Importe"

                // Dibujar las cabeceras de la tabla
                ev.Graphics.DrawString("ID Socio", dataFont, dataBrush, 20, yPosition);
                ev.Graphics.DrawString("Nombre", dataFont, dataBrush, 20 + columnWidth1, yPosition);
                ev.Graphics.DrawString("Apellido", dataFont, dataBrush, 20 + columnWidth1 + columnWidth2, yPosition);
                ev.Graphics.DrawString("Fecha Vencimiento", dataFont, dataBrush, 20 + columnWidth1 + columnWidth2 + columnWidth3, yPosition);
                ev.Graphics.DrawString("Importe", dataFont, dataBrush, 20 + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4, yPosition);

                // Ajustar la posición para los datos
                yPosition += 30; // Espaciado entre cabecera y datos

                // Recorrer las filas del DataGridView y dibujarlas en el PDF
                foreach (DataGridViewRow row in dgvCuotasVencidas.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string socioID = row.Cells["socioID"].Value.ToString();
                        string nombre = row.Cells["nombre"].Value.ToString();
                        string apellido = row.Cells["apellido"].Value.ToString();
                        string fechaVencimiento = row.Cells["fechaVencimiento"].Value.ToString();
                        string importe = row.Cells["importe"].Value.ToString();

                        // Imprimir cada fila de datos
                        ev.Graphics.DrawString(socioID, dataFont, dataBrush, 20, yPosition);
                        ev.Graphics.DrawString(nombre, dataFont, dataBrush, 20 + columnWidth1, yPosition);
                        ev.Graphics.DrawString(apellido, dataFont, dataBrush, 20 + columnWidth1 + columnWidth2, yPosition);
                        ev.Graphics.DrawString(fechaVencimiento, dataFont, dataBrush, 20 + columnWidth1 + columnWidth2 + columnWidth3, yPosition);
                        ev.Graphics.DrawString(importe, dataFont, dataBrush, 20 + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4, yPosition);

                        // Ajustar la posición para la siguiente fila
                        yPosition += 25;

                        // Comprobar si se alcanza el final de la página, si es así, continuar en la siguiente
                        if (yPosition > ev.MarginBounds.Bottom)
                        {
                            ev.HasMorePages = true;
                            return;
                        }
                    }
                }

                // No hay más páginas que imprimir
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


    }
}
