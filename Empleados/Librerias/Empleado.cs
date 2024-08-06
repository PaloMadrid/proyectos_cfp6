using System.Text;

namespace Librerias
{
    public abstract class Empleado
    {
        /*
         Crear la clase Empleado con los atributos Nombre, Salario,Departamento,Antiguedad.
        Declarar el método abstracto Trabajar().
        Implementar el método virtual MostrarInfo() para mostrar la información básica del empleado.
        Implementar el método virtual CalcularBonificacion() para calcular una bonificación base, por defecto es 0.
        Declarar el método abstracto SueldoTotal(), retorna la informacion de la suma del sueldo mas el valor de la bonificacion


        solucion E:\personal\curso programacion\practicas\funciones01
         */

        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        protected string Nombre { get => nombre; set => nombre = value; }
        protected double Salario { get => salario; set => salario = value; }
        protected string Departamento { get => departamento; set => departamento = value; }
        protected int Antiguedad { get => antiguedad; set => antiguedad = value; }

        public Empleado(string nombre, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = 10000;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public abstract string Trabajar();

        public virtual string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Departamento: {this.departamento}");
            sb.AppendLine($"Salario: {this.salario}");
            sb.AppendLine($"Antigüedad: {this.antiguedad}");

            return sb.ToString();

        }

        public virtual double CalcularBonificacion()
        {
            return 0;
        }

        public virtual double SueldoTotal()
        {
            return this.salario + CalcularBonificacion();
        }
    }
}
