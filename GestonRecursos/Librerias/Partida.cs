namespace Librerias
{
    public class Partida
    {
        string nombre;
        int dias;
        string dificultad;

        public Partida(string nombre, string dificultad, int dias)
        {
            this.nombre = nombre;
            this.dificultad = dificultad;
            this.dias = dias;
        }

        public Partida(string nombre, string dificultad)
            : this(nombre, dificultad, 0)
        {
            // No es necesario volver a asignar los valores ya que se hace en el constructor completo
        }


        public string Nombre { get => nombre; set => nombre = value; }

        public string Dificultad { get => dificultad; set => dificultad = value; }

        public int Dias { get => dias; set => dias = value; }

        public static List<Partida> listaDePartidas()
        {
            List<Partida> partidas = new List<Partida>
                {
               new Partida ("prueba","Medio")
                };

            return partidas;
        }
    }
}
