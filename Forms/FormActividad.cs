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
    public partial class FormActividad : Form
    {
        // Diccionario que mapea actividades a montos
        private Dictionary<string, decimal> actividadesMontos = new Dictionary<string, decimal>()
        {
            { "Musculación y Aparatos", 2000 },
            { "Pilates", 2500 },
            { "Yoga", 2300 },
            { "Zumba", 2200 },
            { "Natación", 3000 }
        };

        public FormActividad()
        {
            InitializeComponent();
            btnSalir.Click += btnSalir_Click;
            cboAct.SelectedIndexChanged += cboAct_SelectedIndexChanged;
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
    }
}
