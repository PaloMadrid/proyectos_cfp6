using Librerias;

namespace Testeo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado gerente1 = new Gerente("Mariano", "Desarrollo", 8, 10);
            Empleado gerente2 = new Gerente("Laura", "Analisis", 10, 8);
            Empleado analista1 = new Analista("Hernan", "Analisis", 4, "Datos", "Veterinaria");
            Empleado analista2 = new Analista("Maria", "Analisis", 3, "Riesgos", "Bar");
            Empleado programador1 = new Desarrollador("Pedro", "Desarrollo", 1, "C#", "Junior");
            Empleado programador2 = new Desarrollador("Sandra", "Desarrollo", 4, "Java", "Senior");
            Empleado programador3 = new Desarrollador("Pepe", "Desarrollo", 4, "C#", "Senior");

            List<Empleado> empleados = new List<Empleado>() { gerente1, gerente2, analista1, analista2, programador1, programador2, programador3 };

            foreach (Empleado item in empleados)
            {
                Console.WriteLine(item.MostrarInfo());
                Console.WriteLine(item.Trabajar());
                Console.WriteLine(item.SueldoTotal());

                if (item.GetType() == typeof(Gerente))
                {
                    Console.WriteLine(((Gerente)item).Planificar());
                }
                else if (item.GetType() == typeof(Desarrollador))
                {
                    Console.WriteLine(((Desarrollador)item).DepurarCodigo());
                }
                else if (item.GetType() == typeof(Analista))
                {
                    Console.WriteLine(((Analista)item).PrepararInforme());

                }
                Console.WriteLine("---------------------------");
            }
        }
    }
}
