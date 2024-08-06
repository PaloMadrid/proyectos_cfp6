using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Analista:Empleado
    {
        /*Crear la clase Analista que herede de Empleado.
Agregar los atributos Especialidad y Proyectos.
Implementar el método Trabajar() para que imprima "El analista está analizando los datos."
Sobrescribir CalcularBonificacion() para calcular una bonificación específica para analistas, 
        los desarrolladores reciben una bonificacion del 10% del salario.
Implementar el método PrepararInforme(),debe informar que le analista esta preparando los informes de sus proyectos.
Implementar el método SalarioTotal()*/

        string especialidad;
        string proyectos;

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Proyectos { get => proyectos; set => proyectos = value; }

        public Analista(string nombre, string departamento, int antiguedad, string especialidad, string proyectos) 
            : base(nombre, departamento, antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;
        }

        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Especialidad: {this.especialidad}");
            sb.Append($"Proyectos: {this.proyectos}");

            return base.MostrarInfo() + sb.ToString();
        }

        public override double SueldoTotal()
        {
            return CalcularBonificacion()*base.Salario;
        }
        public string PrepararInforme()
        {
            return $"{this.Nombre} esta preparando los informes de {this.proyectos}";
        }

        public override double CalcularBonificacion()
        {
            return 1.10;
        }
        public override string Trabajar()
        {
            return "El analista está analizando los datos.";
        }


    }
}
