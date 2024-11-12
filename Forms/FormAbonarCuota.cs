﻿using club_deportivo.Datos;
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
                    CargarDatosCuota(); // Refresca la información de la cuota en la interfaz
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

        private void FormAbonarCuota_Load(object sender, EventArgs e)
        {
            // Puedes realizar cualquier configuración adicional al cargar el formulario aquí.
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            // Puedes manejar eventos adicionales si es necesario.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Puedes manejar eventos adicionales si es necesario.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Volver al menú inicial
            FormMenu menuForm = new FormMenu();
            menuForm.Show();

            this.Close();
        }
    }
}
