using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Socio : Cliente
{
    public int SocioID { get; set; }

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
}
