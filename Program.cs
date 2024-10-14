using System;
using System.IO;
using MySql.Data.MySqlClient;
using club_deportivo.Datos;
using System.Windows.Forms;
using club_deportivo;

namespace club_deportivo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
