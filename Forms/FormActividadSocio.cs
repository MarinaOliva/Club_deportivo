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
    public partial class FormActividadSocio : Form
    {
        public FormActividadSocio()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FormMenu menuForm = new FormMenu();
            menuForm.Show();
            this.Close();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int socioID = Convert.ToInt32(txtNumSocio.Text); // Obtener el ID del socio desde el textbox

            // Verificar cuántas actividades tiene inscritas el socio
            int actividadesInscritas = Actividad.ContarActividadesInscritas(socioID);
            int maxActividadesPermitidas = 3; // Número máximo de actividades permitidas

            // Verificar cuántas actividades ha seleccionado el usuario
            int actividadesSeleccionadas = 0;
            if (chkAikido.Checked) actividadesSeleccionadas++;
            if (chkPilates.Checked) actividadesSeleccionadas++;
            if (chkYoga.Checked) actividadesSeleccionadas++;
            if (chkZumba.Checked) actividadesSeleccionadas++;

            // Verificar si las actividades seleccionadas junto con las ya inscritas superan el máximo permitido
            if (actividadesSeleccionadas > maxActividadesPermitidas)
            {
                MessageBox.Show($"Solo puede inscribirse a un máximo de {maxActividadesPermitidas} actividades. Elija menos.");
                return;  // No continuar con la inscripción
            }

            bool inscripcionExitosa = true;
            List<int> actividadesInscritasConExito = new List<int>();

            // Verificar qué actividades han sido seleccionadas
            if (chkAikido.Checked)
            {
                int actividadID = Actividad.ObtenerIdActividad("Aikido");
                Actividad actividad = new Actividad(actividadID);

                if (actividad.HayCuposDisponibles())
                {
                    if (Actividad.InscribirSocio(socioID, actividadID))
                    {
                        actividadesInscritasConExito.Add(actividadID);
                    }
                    else
                    {
                        MessageBox.Show("Error al inscribir en Aikido. Verifique los cupos disponibles.");
                        inscripcionExitosa = false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para Aikido.");
                    inscripcionExitosa = false;
                }
            }

            if (chkPilates.Checked)
            {
                int actividadID = Actividad.ObtenerIdActividad("Pilates");
                Actividad actividad = new Actividad(actividadID);

                if (actividad.HayCuposDisponibles())
                {
                    if (Actividad.InscribirSocio(socioID, actividadID))
                    {
                        actividadesInscritasConExito.Add(actividadID);
                    }
                    else
                    {
                        MessageBox.Show("Error al inscribir en Pilates. Verifique los cupos disponibles.");
                        inscripcionExitosa = false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para Pilates.");
                    inscripcionExitosa = false;
                }
            }

            if (chkYoga.Checked)
            {
                int actividadID = Actividad.ObtenerIdActividad("Yoga");
                Actividad actividad = new Actividad(actividadID);

                if (actividad.HayCuposDisponibles())
                {
                    if (Actividad.InscribirSocio(socioID, actividadID))
                    {
                        actividadesInscritasConExito.Add(actividadID);
                    }
                    else
                    {
                        MessageBox.Show("Error al inscribir en Yoga. Verifique los cupos disponibles.");
                        inscripcionExitosa = false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para Yoga.");
                    inscripcionExitosa = false;
                }
            }

            if (chkZumba.Checked)
            {
                int actividadID = Actividad.ObtenerIdActividad("Zumba");
                Actividad actividad = new Actividad(actividadID);

                if (actividad.HayCuposDisponibles())
                {
                    if (Actividad.InscribirSocio(socioID, actividadID))
                    {
                        actividadesInscritasConExito.Add(actividadID);
                    }
                    else
                    {
                        MessageBox.Show("Error al inscribir en Zumba. Verifique los cupos disponibles.");
                        inscripcionExitosa = false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay cupos disponibles para Zumba.");
                    inscripcionExitosa = false;
                }
            }

            // Verificar si se logró inscribir en alguna actividad
            if (inscripcionExitosa)
            {
                MessageBox.Show("Inscripción exitosa!");
            }
            else
            {
                MessageBox.Show("Algunas actividades no pudieron ser inscriptas. Verifique los cupos disponibles.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número de socio ingresado
                int numSocio = int.Parse(txtNumSocio.Text);

                // Crear una instancia de la clase Socio
                Socio socio = new Socio();
                socio.SocioID = numSocio; // Asignar el ID del socio a la instancia

                // Consultar las actividades asociadas al número de socio
                List<string> actividadesInscritas = socio.ObtenerActividades();

                if (actividadesInscritas.Count > 0)
                {
                    // Si el socio está inscrito en alguna actividad, mostrar las actividades
                    lblSocioInsc.Text = "Socio ya inscripto en:\n";
                    foreach (var actividad in actividadesInscritas)
                    {
                        lblSocioInsc.Text += actividad + "\n";
                    }
                }
                else
                {
                    // Si no hay actividades, informar al usuario
                    lblSocioInsc.Text = "El socio no está inscripto en ninguna actividad.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las actividades del socio: " + ex.Message);
            }
        }


    }
}
