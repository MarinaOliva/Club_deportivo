using club_deportivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NoSocio : Cliente
{
    public string NombreCompleto => $"{Nombre} {Apellido}";
    public string DNI { get; set; }

    public bool InscribirseEnActividad(string actividadSeleccionada, decimal monto, out string mensaje)
    {
        // Obtener ID de la actividad
        int idActividadSeleccionada = Actividad.ObtenerIdActividad(actividadSeleccionada);

        if (idActividadSeleccionada != -1)
        {
            Actividad actividad = new Actividad(idActividadSeleccionada);

            // Verificar si hay cupos disponibles
            if (actividad.HayCuposDisponibles())
            {
                // Realizar inscripción
                actividad.ActualizarCupos();

                // Crear el mensaje de confirmación
                mensaje = $"Inscripción exitosa a la actividad {actividadSeleccionada} de ${monto}.";
                return true;
            }
            else
            {
                mensaje = "No hay cupos disponibles para esta actividad.";
                return false;
            }
        }

        mensaje = "Actividad no encontrada.";
        return false;
    }
}
