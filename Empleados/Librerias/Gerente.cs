using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Gerente: Empleado
    {
        /*Implementar el método Trabajar() para que imprima "El gerente está gestionando el departamento."
Sobrescribir CalcularBonificacion() para calcular una bonificación específica para gerentes, 
       los gerentes reciben una bonificacion del 25% del salario.
Implementar el método Planificar(), es retorna un string que informara que el gerente es creando 
       una planificacion para la cantidad de empleados que tenga a cargo.
Implementar el método SalarioTotal().*/

        int NumeroEmpleados;

        public int NumeroEmpleados1 { get => NumeroEmpleados; set => NumeroEmpleados = value; }

        public Gerente(string nombre, string departamento, int antiguedad, int NumeroEmpleados)
            :base(nombre, departamento,antiguedad)
        {
            this.NumeroEmpleados=NumeroEmpleados;
        }

        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Cantidad de Empleados: { this.NumeroEmpleados}");

            return base.MostrarInfo() + sb.ToString();
        }

        public override double SueldoTotal()
        {
            return CalcularBonificacion() * base.salario;
        }

        public string Planificar()
        {
            return $"{this.nombre} creando una planificacion para {this.NumeroEmpleados} de empleados";
        }

        public override double CalcularBonificacion()
        {
            return 1.25;
        }

        public override string Trabajar()
        {
            return "El gerente está gestionando el departamento.";
        }
    }
}
