using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System.Data;


namespace club_deportivo.Datos
{
    internal class Administrador
    {
        public DataTable Log_Administrador(string L_Adm, string P_Adm)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                // Usar directamente Program.ConnectionString para crear la conexión
                sqlCon.ConnectionString = Program.ConnectionString;

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Cambiar los nombres de los parámetros a los nuevos
                comando.Parameters.Add("usuarioNombre", MySqlDbType.VarChar).Value = L_Adm;
                comando.Parameters.Add("usuarioContrasena", MySqlDbType.VarChar).Value = P_Adm;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar validar las credenciales: " + ex.Message);
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
