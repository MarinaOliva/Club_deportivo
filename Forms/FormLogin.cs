﻿using System;
using System.Data;
using System.Windows.Forms;
using club_deportivo.Datos; 

namespace club_deportivo
{
    public partial class FormLogin : Form
    {
        private Usuarios usuarios; // Instancia de la clase Usuarios

        public FormLogin()
        {
            InitializeComponent();
            usuarios = new Usuarios(); // Inicializa la clase Usuarios
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioNombre = txtUsuario.Text;
            string usuarioContrasena = txtContrasena.Text;

            try
            {
                // Llama al método Log_Usu para verificar credenciales
                DataTable resultado = usuarios.Log_Usu(usuarioNombre, usuarioContrasena);

                if (resultado.Rows.Count > 0) // Si hay resultados, el login fue exitoso
                {
                    MessageBox.Show("Login exitoso!");

                    // Oculta el formulario de login
                    this.Hide();

                    // Crea una nueva instancia del formulario de menú
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show(); // Muestra el formulario de menú
                }
                else
                {
                    // Muestra un mensaje de error si las credenciales son incorrectas
                    MessageBox.Show("Usuario y/o contraseña incorrectos. Intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la base de datos: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear(); // Limpiar el TextBox del usuario
            txtContrasena.Clear(); // Limpiar el TextBox de la contraseña
        }
    }
}