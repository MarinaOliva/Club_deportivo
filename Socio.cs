using club_deportivo;
using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Socio : Cliente
{
    public int SocioID { get; set; }
    public string EstadoCuota { get; set; }
    public string FechaValidez { get; set; }
    public List<string> Actividades { get; set; } = new List<string>();

    // Propiedad para almacenar la cuota
    public Cuotas Cuota { get; set; }

    // Constructor donde se pasa el SocioID
    public Socio(int socioId) : base()
    {
        SocioID = socioId;
        Actividades = new List<string>();
        MessageBox.Show("ClienteID: " + ClienteID);
        CargarInformacionSocio();  // Llamada al método para cargar la información
    }

    public Socio() : base()
    {
        Actividades = new List<string>();
    }

    // Método para guardar socio
    public void GuardarSocio()
    {
        using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
        {
            conn.Open();
            string query = "INSERT INTO Socio (clienteID) VALUES (@clienteID);";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@clienteID", ClienteID);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Método privado para cargar la información del socio, delegando la lógica de cuota a la clase Cuotas
    public void CargarInformacionSocio()
    {
        // Llama al método de la clase base Cliente para cargar datos básicos del cliente
        CargarClientePorId(ClienteID);

        using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
        {
            conn.Open();

            // Consulta para obtener la información del socio y actividades
            string query = @"
        SELECT 
            a.nombreActividad AS Actividad
        FROM Socio s
        LEFT JOIN SocioActividad sa ON sa.socioID = s.socioID
        LEFT JOIN Actividad a ON a.idActividad = sa.actividadID 
        WHERE s.socioID = @socioId";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Agregar parámetro para la consulta
                cmd.Parameters.AddWithValue("@socioId", SocioID);

                // Ejecutar la consulta y obtener los resultados
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Limpiar la lista de actividades antes de llenarla
                    Actividades.Clear();

                    // Llenar la lista de actividades asociadas al socio
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("Actividad")))
                        {
                            Actividades.Add(reader.GetString("Actividad"));
                        }
                    }

                    // Depuración: Verificar si las actividades fueron cargadas
                    if (Actividades.Count > 0)
                    {
                        MessageBox.Show($"Actividades cargadas: {string.Join(", ", Actividades)}");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron actividades asociadas.");
                    }
                }
            }

            // Obtener la cuota usando la clase Cuotas
            Cuota = Cuotas.ObtenerCuotaPorSocio(SocioID);

            // Asignar estado de la cuota
            if (Cuota != null)
            {
                EstadoCuota = Cuota.EstadoCuota();
                MessageBox.Show($"Estado de la cuota: {EstadoCuota}");

                // Asignar la fecha de validez
                if (Cuota.FechaValidez().HasValue)
                {
                    FechaValidez = Cuota.FechaValidez().Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    FechaValidez = "Sin validez";
                }

                // Depuración: Verificar la fecha de validez
                MessageBox.Show($"Fecha de validez: {FechaValidez}");
            }
            else
            {
                MessageBox.Show("No se encontró cuota para el socio.");
            }
        }
    }
}
