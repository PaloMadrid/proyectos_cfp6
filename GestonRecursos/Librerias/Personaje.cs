using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    internal class Personaje
    {
        string nombre;
        int suerte;
        int vida;
        int hambre;
        string salud;
        int xp;

        public Personaje(string nombre, int suerte)
        {
            this.nombre = nombre;
            this.suerte = suerte;
            this.vida = 100;
            this.hambre = 10;
            this.salud = "Bueno";
            this.xp = 0;
        }

        public string Nombre { get => nombre; }
        public int Suerte { get => suerte; set => suerte = value; }
        public int Vida { get => vida; set => vida = value; }
        public string Salud { get => salud; set => salud = value; }

        public int Xp { get => xp; set => xp = value; }

        public List<Personaje> ListaDePersonajes()
        {
            List<Personaje> personajes = new List<Personaje>()
            {
                new Personaje ("Sonya",9),
                new Personaje ("Jonny",8),
                new Personaje ( "Sub Zero" ,9),
                new Personaje("Milena",6)
            };

            return personajes;
        }

        //public void ConsumirHambre()
        //{
        //    if

        //}
    }
}
