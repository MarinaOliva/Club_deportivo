using club_deportivo.Datos;
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
    public partial class FormAbonarCuota : Form
    {
        private int socioId;
        private Cuotas cuota;

        public FormAbonarCuota(int socioId)
        {
            InitializeComponent();
            this.socioId = socioId;

            // Obtiene la información de la cuota al cargar el formulario
            CargarDatosCuota();
        }

        private void CargarDatosCuota()
        {
            // Obtiene la cuota del socio usando el número de socio
            cuota = Cuotas.ObtenerCuotaPorSocio(socioId);

            if (cuota != null)
            {
                // Muestra la información de la cuota en las etiquetas
                lblNombre.Text = $"Nombre: {cuota.Nombre} {cuota.Apellido}";
                lblNumSocio.Text = $"Socio n° : {socioId}";
                lblMonto.Text = $"Monto de la cuota: ${cuota.Importe}";
                lblFecha.Text = $"Fecha de pago: {(cuota.FechaPago.HasValue ? cuota.FechaPago.Value.ToString("dd/MM/yyyy") : "No pagada")}";
                lblVencimiento.Text = $"Fecha de vencimiento: {cuota.FechaVencimiento:dd/MM/yyyy}";
            }
            else
            {
                // Si no encuentra la cuota, muestra un mensaje de error y cierra el formulario
                MessageBox.Show("No se encontró la información de la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cuota != null && !cuota.FechaPago.HasValue)
            {
                // Registra el pago en la base de datos
                bool pagoExitoso = Cuotas.RegistrarPagoCuota(socioId);

                if (pagoExitoso)
                {
                    MessageBox.Show("El pago se ha registrado exitosamente.", "Pago Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Llamar al método para cargar nuevamente los datos de la cuota
                    CargarDatosCuota();

                    // Obtener el comprobante (todos los datos necesarios)
                    Cliente cliente = new Cliente(socioId); // Instancia de Cliente con el socioId
                    var comprobanteData = cliente.ObtenerComprobante(socioId); // Obtiene la tupla con los datos del comprobante

                    // Crear y mostrar el formulario de comprobante con los datos del pago
                    FormComprobante formComprobante = new FormComprobante(
                        comprobanteData.nombre,
                        comprobanteData.dni,
                        comprobanteData.monto,
                        comprobanteData.fechaPago
                    );
                    formComprobante.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el pago. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Esta cuota ya está pagada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Volver al menú inicial
            FormMenu menuForm = new FormMenu();
            menuForm.Show();
            this.Close();
        }

        private void FormAbonarCuota_Load(object sender, EventArgs e)
        {

        }
    }
}

