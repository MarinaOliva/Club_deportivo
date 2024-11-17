using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using club_deportivo.Datos;
using MySql.Data.MySqlClient;

namespace club_deportivo.Forms
{
    public partial class FormInfoSocio : Form
    {
        private FormMenu _formMenu; // Referencia al FormMenu principal
        private Socio socioActual; // Variable miembro para almacenar el objeto Socio

        // Constructor que recibe la referencia al formulario principal (FormMenu)
        public FormInfoSocio(FormMenu formMenu)
        {
            InitializeComponent();
            _formMenu = formMenu; // Guardamos la referencia
            btnOut.Click += button_out_Click; // Vinculamos el evento del botón "Salir"
        }

        public void LoadData(Socio socio, Cuotas cuota)
        {
            socioActual = socio;
            /* Depuración: Verificar los datos recibidos
            MessageBox.Show($"Cargando datos para: {socio.Nombre} {socio.Apellido}, N° Documento: {socio.NumDoc}");
            */

            // Usamos los métodos de la clase Socio para obtener los datos
            lblNombre.Text = "Nombre: " + socio.Nombre;
            lblApellido.Text = "Apellido: " + socio.Apellido;

            // Verificar que el número de documento y tipo de documento no estén vacíos
            if (socio.NumDoc == 0)
            {
                MessageBox.Show("Número de documento está vacío o es 0.");
            }
            lblDNI.Text = "N°: " + socio.NumDoc.ToString();
            lblTipoDoc.Text = "Tipo doc: " + socio.TipoDoc;

            // Verificar que la cuota no sea nula
            if (cuota != null)
            {
                lblCuota.Text = "Estado cuota: " + cuota.EstadoCuota();
            }
            else
            {
                MessageBox.Show("La cuota está vacía.");
            }

            // Mostrar la fecha de validez usando el método FechaValidez
            lblValidez.Text = "Fecha de validez: " + cuota?.FechaValidez()?.ToString("dd/MM/yyyy") ?? "Sin validez";


            // Generar la cadena con las actividades numeradas
            if (socio.Actividades.Count > 0)
            {
                string actividadesListadas = "Actividades:\n";
                for (int i = 0; i < socio.Actividades.Count; i++)
                {
                    actividadesListadas += $"{i + 1}. {socio.Actividades[i]}\n";
                }
                lblAct.Text = actividadesListadas;
            }
            else
            {
                lblAct.Text = "No tiene actividades registradas.";
            }
        }

        // Evento Click para el botón Salir
        private void button_out_Click(object sender, EventArgs e)
        {
            // Verifica si _formMenu no es nulo antes de usarlo
            if (_formMenu != null)
            {
                _formMenu.Show(); // Muestra el formulario principal FormMenu
                this.Close(); // Cierra el formulario actual
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            // Obtener los datos del socio usando el método ObtenerDatosCarnet
            var (nombre, apellido, numeroSocio) = socioActual.ObtenerDatosCarnet();

            // Crear una instancia de FormCarnet
            FormCarnet formCarnet = new FormCarnet(nombre, apellido, numeroSocio);

            // Mostrar el formulario de carnet
            formCarnet.Show();
            //this.Hide();  // Ocultar FormInfoSocio si es necesario
        }

    }
}
