using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace LoginClub.Datos
{
    internal class Usuarios
    {
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Cambiar los nombres de los parámetros a los nuevos
                comando.Parameters.Add("usuarioNombre", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("usuarioContrasena", MySqlDbType.VarChar).Value = P_Usu;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
