using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace club_deportivo.Forms
{
    public partial class FormInfoSocio : Form
    {
        private FormMenu _formMenu; // Referencia al FormMenu principal

        // Constructor que recibe la referencia al formulario principal (FormMenu)
        public FormInfoSocio(FormMenu formMenu)
        {
            InitializeComponent();
            _formMenu = formMenu; // Guardamos la referencia
            btnOut.Click += button_out_Click; // Vinculamos el evento del botón "Salir"
        }

        public void LoadData(MySqlDataReader reader)
        {
            lblDNI.Text = "N° Doc ingresado: " + reader["numDoc"].ToString();       // N° Doc ingresado
            lblNombre.Text = "Nombre: " + reader["nombre"].ToString();                 // Nombre
            lblApellido.Text = "Apellido: " + reader["apellido"].ToString();           // Apellido
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
    }
}
