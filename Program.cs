using System;
using MySql.Data.MySqlClient;
using club_deportivo.Datos;
using System.Diagnostics;
using club_deportivo;

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
