using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Windows.Forms;

namespace club_deportivo.Forms
{
    public partial class FormActividadNoSocio : Form
    {
        // Diccionario que mapea actividades a montos
        private Dictionary<string, decimal> actividadesMontos = new Dictionary<string, decimal>()
        {
            
            { "Pilates", 2500 },
            { "Yoga", 2300 },
            { "Zumba", 2200 },
          
        };

        public FormActividadNoSocio()
        {
            InitializeComponent();
            btnSalir.Click += btnSalir_Click;
            cboAct.SelectedIndexChanged += cboAct_SelectedIndexChanged;
            btnPagar.Click += btnPagar_Click;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ComboBox de montos
            cboMonto.Items.Clear();

            // Obtener la actividad seleccionada
            string actividadSeleccionada = cboAct.SelectedItem?.ToString();

            // Verificar si la actividad tiene un monto asociado
            if (actividadSeleccionada != null && actividadesMontos.ContainsKey(actividadSeleccionada))
            {
                decimal monto = actividadesMontos[actividadSeleccionada];
                cboMonto.Items.Add(monto);  // Agregar el monto al ComboBox
                cboMonto.SelectedIndex = 0;  // Seleccionar automáticamente el monto
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombre = txtNombre.Text + " " + txtApellido.Text;
            string dni = txtDNI.Text;
            string actividadSeleccionada = cboAct.SelectedItem?.ToString();
            decimal monto = 0.0m;
            if (cboMonto.SelectedItem != null)
            {
                monto = Convert.ToDecimal(cboMonto.SelectedItem);
            }

            DateTime fechaPago = DateTime.Now;  // Fecha actual como fecha de pago

            // Obtener el id de la actividad seleccionada desde la clase Actividad
            int idActividadSeleccionada = Actividad.ObtenerIdActividad(actividadSeleccionada);

            // Verificar si hay cupos disponibles para la actividad seleccionada
            if (idActividadSeleccionada != -1)
            {
                // Crear una instancia de Actividad para llamar a los métodos de instancia
                Actividad actividad = new Actividad(idActividadSeleccionada) { IdActividad = idActividadSeleccionada };

                if (actividad.HayCuposDisponibles()) // Llamar al método de instancia
                {
                    // Crear una nueva instancia de FormComprobante y pasar los datos
                    FormComprobante comprobante = new FormComprobante(nombre, dni, monto, fechaPago);

                    // Mostrar el formulario de comprobante
                    comprobante.Show();

                    // Llamar al método de instancia para actualizar los cupos
                    actividad.ActualizarCupos();
                }
                else
                {
                    // Mostrar un mensaje si no hay cupos disponibles
                    MessageBox.Show("No hay cupos disponibles para esta actividad. Por favor, elija otra.");
                }
            }
        }


    }
}
