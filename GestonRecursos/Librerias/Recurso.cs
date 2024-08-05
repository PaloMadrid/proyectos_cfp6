using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    internal class Recurso
    {
        string tipo;
        int cantidad;
        string descripcion;

        public Recurso(string tipo, int cantidad, string descripcion)
        {
            this.tipo = tipo;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }

        public string Tipo { get => tipo; }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public string Descripcion { get => descripcion; }

        public List<Recurso> listaDeRecursos()
        {
            return new List<Recurso>
                {
                new Recurso("Comida", 5, "Sirve para para evitar que tu personaje se muera de hambre"),
                new Recurso("Agua", 5, "Sirve para evitar que tu personaje se muera deshidratado"),
                new Recurso("Traje", 1, "Sirve para hacer trajes que te permitan salir al exterior"),
                new Recurso("Medicina", 2, "Sirve para contrarestar enfermedades"),
                new Recurso("Vendas",3,"Sirve para detener hemorragias")
                };
        }
    }
}
