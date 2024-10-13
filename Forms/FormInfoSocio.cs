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
            button_out.Click += button_out_Click; // Vinculamos el evento del botón "Salir"
        }

        public void LoadData(MySqlDataReader reader)
        {
            label_dniIng.Text = "N° Doc ingresado: " + reader["numDoc"].ToString();       // N° Doc ingresado
            label_nombre.Text = "Nombre: " + reader["nombre"].ToString();                 // Nombre
            label_apellido.Text = "Apellido: " + reader["apellido"].ToString();           // Apellido
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
    }
}
