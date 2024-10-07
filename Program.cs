using System;
using System.Collections.Generic;

// Clase Cliente (superclase de Socio y NoSocio)
public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    private string TipoDoc { get; set; }
    private int NumDoc { get; set; }
    private int Telefono { get; set; }
    private string Email { get; set; }
    public bool PresentaAptoFisico { get; set; }

    public Cliente(string nombre, string apellido, string tipoDoc, int numDoc, int telefono, string email)
    {
        Nombre = nombre;
        Apellido = apellido;
        TipoDoc = tipoDoc;
        NumDoc = numDoc;
        Telefono = telefono;
        Email = email;
    }
}

// Clase Socio que hereda de Cliente
public class Socio : Cliente
{
    public int SocioID { get; private set; }
    public bool AdeudaCuota { get; private set; }
    public List<Actividad> ActividadesInscripto { get; private set; }

    public Socio(string nombre, string apellido, string tipoDoc, int numDoc, int telefono, string email, int socioID)
        : base(nombre, apellido, tipoDoc, numDoc, telefono, email)
    {
        SocioID = socioID;
        ActividadesInscripto = new List<Actividad>();
    }

    public static string AltaSocio(List<Socio> socios, string nombre, string apellido, string tipoDoc, int numDoc, int telefono, string email)
    {
        if (socios.Exists(s => s.Nombre == nombre && s.Apellido == apellido))
            return $"El socio {nombre} {apellido} ya está registrado.";

        int socioID = socios.Count + 1000;
        Socio nuevoSocio = new Socio(nombre, apellido, tipoDoc, numDoc, telefono, email, socioID);
        socios.Add(nuevoSocio);
        return $"El socio {nombre} {apellido} ha sido dado de alta correctamente! Su número de socio es: {socioID}";
    }
}

// Clase NoSocio que hereda de Cliente
public class NoSocio : Cliente
{
    public int NoSocioID { get; private set; }

    public NoSocio(string nombre, string apellido, string tipoDoc, int numDoc, int telefono, string email, int noSocioID)
        : base(nombre, apellido, tipoDoc, numDoc, telefono, email)
    {
        NoSocioID = noSocioID;
    }
}

// Clase Actividad
public class Actividad
{
    public string Nombre { get; private set; }
    public int Cupo { get; private set; }
    public List<Socio> SociosInscriptos { get; private set; }

    public Actividad(string nombre, int cupo)
    {
        Nombre = nombre;
        Cupo = cupo;
        SociosInscriptos = new List<Socio>();
    }
}

// Clase ClubDeportivo
public class ClubDeportivo
{
    public List<Socio> socios = new List<Socio>();
    public List<Actividad> actividades = new List<Actividad>();

    public string InscribirActividad(int idSocio, string nombreActividad)
    {
        Socio socio = socios.Find(s => s.SocioID == idSocio);
        if (socio == null)
            return "SOCIO INEXISTENTE";

        Actividad actividad = actividades.Find(a => a.Nombre.Equals(nombreActividad, StringComparison.OrdinalIgnoreCase));
        if (actividad == null)
            return "ACTIVIDAD INEXISTENTE";

        if (socio.ActividadesInscripto.Count >= 3)
            return "TOPE DE ACTIVIDADES ALCANZADO";

        if (actividad.Cupo <= actividad.SociosInscriptos.Count)
            return "No hay cupos disponibles";

        actividad.SociosInscriptos.Add(socio);
        socio.ActividadesInscripto.Add(actividad);

        return "INSCRIPCIÓN EXITOSA";
    }

    public void AgregarActividad(string nombre, int cupo)
    {
        actividades.Add(new Actividad(nombre, cupo));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ClubDeportivo club = new ClubDeportivo();

        // Agregar algunas actividades
        club.AgregarActividad("Fútbol", 20);
        club.AgregarActividad("Natación", 15);
        club.AgregarActividad("Tenis", 10);
        club.AgregarActividad("Musculación y Aparatos", 25);

        Console.Write("Ingrese la cantidad de socios a registrar: ");
        int cantidadSocios = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidadSocios; i++)
        {
            Console.Write($"Ingrese el nombre del socio {i + 1}: ");
            string nombre = Console.ReadLine();
            Console.Write($"Ingrese el apellido del socio {i + 1}: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el tipo de documento: ");
            string tipoDoc = Console.ReadLine();
            Console.Write("Ingrese el número de documento: ");
            int numDoc = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el teléfono: ");
            int telefono = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el email: ");
            string email = Console.ReadLine();

            string resultadoAlta = Socio.AltaSocio(club.socios, nombre, apellido, tipoDoc, numDoc, telefono, email);
            Console.WriteLine(resultadoAlta);

            if (resultadoAlta.StartsWith("El socio"))
            {
                int idSocio = int.Parse(resultadoAlta.Split(':')[1].Trim());

                // Preguntar si desea inscribirse en actividades
                Console.Write("¿Desea inscribirse en actividades? (s/n): ");
                string respuestaInscripcion = Console.ReadLine().Trim().ToLower();

                if (respuestaInscripcion == "s")
                {
                    bool continuarInscripcion = true;

                    while (continuarInscripcion)
                    {
                        Console.WriteLine("\nActividades disponibles:");
                        foreach (var actividad in club.actividades)
                        {
                            Console.WriteLine(actividad.Nombre);
                        }

                        Console.Write("\nIngrese el nombre de la actividad: ");
                        string nombreActividad = Console.ReadLine();

                        string resultado = club.InscribirActividad(idSocio, nombreActividad);
                        Console.WriteLine(resultado);

                        if (resultado.Contains("TOPE DE ACTIVIDADES ALCANZADO") ||
                            resultado.Contains("No hay cupos disponibles"))
                        {
                            continuarInscripcion = false; // Finaliza la inscripción si se alcanza el tope o no hay cupo
                        }
                        else
                        {
                            Console.Write("¿Desea inscribirse en otra actividad? (s/n): ");
                            string respuesta = Console.ReadLine();
                            continuarInscripcion = respuesta.Trim().ToLower() == "s";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se inscribió en ninguna actividad.");
                }
            }
        }

        Console.ReadLine();
    }
}
