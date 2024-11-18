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
        // MessageBox.Show("ClienteID: " + ClienteID);
        CargarInformacionSocio();  // Llamada al método para cargar la información
    }

    public Socio() : base()
    {
        Actividades = new List<string>();
    }

    // Método para guardar socio
    public void GuardarSocio()
    {
        try
        {
            // Conexión a la base de datos
            using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
            {
                conn.Open();
                //MessageBox.Show("Conexión exitosa a la base de datos.");

                // Inserción del socio
                string query = "INSERT INTO Socio (clienteID) VALUES (@clienteID);";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clienteID", ClienteID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    //MessageBox.Show($"Socio insertado, filas afectadas: {rowsAffected}");

                    // Verifica si la inserción fue exitosa
                    if (rowsAffected > 0)
                    {
                        // Obtención del SocioID
                        SocioID = (int)cmd.LastInsertedId;
                        //MessageBox.Show($"SocioID obtenido correctamente: {SocioID}");
                    }
                    else
                    {
                        MessageBox.Show("No se insertó el socio.");
                        return;
                    }
                }

                // Inserción de la cuota
                if (SocioID > 0)
                {
                    string queryCuota = "INSERT INTO Cuota (socioID, fechaVencimiento, importe) VALUES (@socioID, @fechaVencimiento, @importe);";
                    using (MySqlCommand cmdCuota = new MySqlCommand(queryCuota, conn))
                    {
                        cmdCuota.Parameters.AddWithValue("@socioID", SocioID);
                        cmdCuota.Parameters.AddWithValue("@fechaVencimiento", DateTime.Now.AddMonths(1)); // Fecha de vencimiento a un mes
                        cmdCuota.Parameters.AddWithValue("@importe", 23000.00m); 

                        int cuotaRowsAffected = cmdCuota.ExecuteNonQuery();
                        //MessageBox.Show($"Cuota insertada, filas afectadas: {cuotaRowsAffected}");
                    }
                }
                else
                {
                    MessageBox.Show("SocioID no válido para insertar la cuota.");
                }
            }
        }
        catch (Exception ex)
        {
            // Captura de cualquier excepción
            MessageBox.Show($"Error: {ex.Message}");
        }
    }


    // Método para cargar la información del socio, delegando la lógica de cuota a la clase Cuotas
    public void CargarInformacionSocio()
    {
        // Llama al método de la clase base Cliente para cargar datos básicos del cliente
        CargarClientePorId(ClienteID);

        using (MySqlConnection conn = new MySqlConnection(Program.ConnectionString))
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

                    /* Depuración: Verificar si las actividades fueron cargadas
                    if (Actividades.Count > 0)
                    {
                        MessageBox.Show($"Actividades cargadas: {string.Join(", ", Actividades)}");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron actividades asociadas.");
                    }
                    */
                }
            }

            // Obtener la cuota usando la clase Cuotas
            Cuota = Cuotas.ObtenerCuotaPorSocio(SocioID);

            // Asignar estado de la cuota
            if (Cuota != null)
            {
                EstadoCuota = Cuota.EstadoCuota();
                //MessageBox.Show($"Estado de la cuota: {EstadoCuota}");

                // Asignar la fecha de validez
                if (Cuota.FechaValidez().HasValue)
                {
                    FechaValidez = Cuota.FechaValidez().Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    FechaValidez = "Sin validez";
                }

                /* Depuración: Verificar la fecha de validez
                MessageBox.Show($"Fecha de validez: {FechaValidez}");*/
            } 
            else
            {
                MessageBox.Show("No se encontró cuota para el socio.");
            }
        }
    }

    // Método para cargar los datos que van a aparecer en el carnet
    public (string Nombre, string Apellido, string NumeroSocio) ObtenerDatosCarnet()
    {
        return ($"Nombre: {Nombre}", $"Apellido: {Apellido}", $"N° Socio: {SocioID}");
    }

    // Método para obtener las actividades en las que está inscripto cada socio
    public List<string> ObtenerActividades()
    {
        List<string> actividades = new List<string>();

        try
        {
            // Crear conexión a la base de datos
            MySqlConnection conexion = new MySqlConnection(Program.ConnectionString);
            conexion.Open();

            // Consulta SQL para obtener las actividades del socio
            string query = @"SELECT a.nombreActividad
                             FROM Actividad a
                             JOIN SocioActividad sa ON a.idActividad = sa.actividadID
                             WHERE sa.socioID = @socioID";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@socioID", this.SocioID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Agregar cada actividad a la lista
                actividades.Add(reader.GetString("nombreActividad"));
            }

            conexion.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al obtener las actividades del socio: " + ex.Message);
        }

        return actividades;
    }
}
