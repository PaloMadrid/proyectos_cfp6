using System.Text;

namespace Evaluacion
{
    public class Computadora
    {
        int capacidadDisco;
        int memoriaRam;
        string procesador;
        List<string> programas;
        string so;

        public Computadora(int capacidadDisco, int memoriaRam, string procesador, string so)
            : this()
        {
            this.capacidadDisco = capacidadDisco;
            this.memoriaRam = memoriaRam;
            this.procesador = procesador;
            this.so = so;
        }

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public int CapacidadDisco { get => capacidadDisco; }
        public int MemoriaRam { get => memoriaRam; }
        public string Procesador { get => procesador; }
        public string Programas
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (string programa in programas)
                {
                    sb.Append(programa + ", ");

                }

                return sb.ToString();
            }
        }
        public string So { get => so; }

        public List<string> GetProgramas()
        {
            return new List<string>(programas);
        }

        public void SetPrograma(string programa)
        {

            this.programas.Add(programa);
        }

        public static List<string> ListadoDeProcesadores()
        {
            List<string> ret = new List<string>
           {
               "i5","i3","i9","ryzen 5","ryzen 7"
             };

            return ret;
        }


    }
}
