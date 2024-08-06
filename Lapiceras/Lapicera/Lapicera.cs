using System.Drawing;

namespace Librerias
{
    public class Lapicera
    {
        //Crear la clase lapicera, esta debe tener los atributos: color, precio, marca, nivelDeTinta.
        //crear propiedades todas las propiedad de lectura.
        //        Un constructor que inicialice color, precio, marca.
        //        Todas las lapiceras se crean con el nivel de tinta al 100.
        //Sobreescribir el metodo ToString() para que muestre todos sus valores.
        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        ///el metodo debe verificar si tiene tinta
        //para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.
        //El metodo public void Recargar() que colocara el nivel a 100 nuevamente.

        int id;
        Color color;
        int precio;
        string marca;
        int nivelDeTinta;

        public Lapicera(Color color, int precio, string marca, int id = 0)
        {

            this.color = color;
            this.precio = precio;
            this.marca = marca;
            this.nivelDeTinta = 100;
            this.id = id;
        }

        public Color Color { get => color; }
        public int Precio { get => precio; }
        public string Marca { get => marca; }
        public int NivelDeTinta { get => nivelDeTinta; }

        public override string ToString()
        {
            return $"Marca: {this.marca} - Color: {this.color} - Precio: {this.precio} - Nivel de tinta: {this.nivelDeTinta}";
        }

        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        //el metodo debe verificar si tiene tinta
        //para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.

        public bool Escribir(int cantLetras)
        {
            bool retorno = false;

            if (cantLetras < this.nivelDeTinta)
            {
                this.nivelDeTinta -= cantLetras;
                retorno = true;
            }

            return retorno;
        }
       
        //El metodo public void Recargar() que colocara el nivel a 100 nuevamente.

        public void Recargar()
        {
            this.nivelDeTinta = 100;
        }

        public static List<Color> ListaDeColores()
        {
            List<Color> colores = new List<Color>()
            {
                Color.Blue,
                Color.Red,
                Color.Black,
                Color.Purple,
                Color.Green

            };

            return colores;
        }
    }
}
