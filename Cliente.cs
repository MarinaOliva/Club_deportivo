using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente
{
    public int ClienteID { get; set; }
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string TipoDoc { get; set; }
    public int NumDoc { get; set; }
    public int Telefono { get; set; }
    public required string Email { get; set; }
    public bool PresentaAptoFisico { get; set; }

    public void GuardarCliente()
    {
        using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
        {
            conn.Open();
            string query = "INSERT INTO Cliente (nombre, apellido, tipoDoc, numDoc, telefono, email, presentaAptoFisico) " +
                           "VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @telefono, @email, @presentaAptoFisico); " +
                           "SELECT LAST_INSERT_ID();";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@tipoDoc", TipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", NumDoc);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@presentaAptoFisico", PresentaAptoFisico);
                ClienteID = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
