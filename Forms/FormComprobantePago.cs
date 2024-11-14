using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace club_deportivo.Forms
{
    public partial class FormComprobantePago : Form
    {
        // Propiedades para recibir los datos del formulario de pago
        public string NombreSocio { get; set; }
        public string DNI { get; set; }
        public int NumeroSocio { get; set; }
        public float MontoAbonado { get; set; }
        public DateTime FechaPago { get; set; }

        public FormComprobantePago()
        {
            InitializeComponent();
        }

        private void FormComprobantePago_Load(object sender, EventArgs e)
        {
            // Asigna los valores a las etiquetas del comprobante de pago
            lblNombreSocio.Text = NombreSocio;
            lblDNI.Text = DNI;
            lblNumeroSocio.Text = NumeroSocio.ToString();
            lblMontoAbonado.Text = $"${MontoAbonado:F2}";
            lblFechaPago.Text = FechaPago.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;  // Oculta el botón durante la impresión
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirComprobante);
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600
            };
            printPreview.ShowDialog();
            btnImprimir.Visible = true;  // Vuelve a mostrar el botón
        }

        private void ImprimirComprobante(object sender, PrintPageEventArgs e)
        {
            // Captura el formulario en una imagen para imprimir
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, new Point(100, 100));
        }

        public void GenerarComprobante(string nombreSocio, string dni, int numeroSocio, float monto, DateTime fecha)
        {
            // Método para configurar los datos del comprobante
            NombreSocio = nombreSocio;
            DNI = dni;
            NumeroSocio = numeroSocio;
            MontoAbonado = monto;
            FechaPago = fecha;

            // Mostrar el formulario
            this.ShowDialog();
        }
    }
}


