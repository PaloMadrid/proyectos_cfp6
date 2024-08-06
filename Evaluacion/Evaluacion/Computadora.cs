using System.Text;

namespace Evaluacion
{
    public class Computadora
    {
        int numeroDeSerie;
        int capacidadDisco;
        int memoriaRam;
        string procesador;
        List<string> programas;
        string so;

        public Computadora(int capacidadDisco, int memoriaRam, string procesador, string so,int numeroDeSerie)
            : this()
        {
            this.numeroDeSerie = numeroDeSerie;
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
                string cadena = "";
                for (int i = 0; i < this.programas.Count; i++)
                {
                    foreach (string programa in programas)
                    {
                        if (i < programas.Count)
                        {
                            cadena+=programa + ", ";
                        }
                        else
                        {
                            cadena += programa;
                        }
                    }
                }
                return cadena;
            }
        }
        public string So { get => so; }
        public int NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }

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

        public void CargarProgramasDesdeUnString(string programas)
        {
            //List<string> list = new List<string>();

            //separa la cadena con la cadena ", " en caso de un solo caracter ',' por medio del metodo split
            //list.AddRange(programas.Split(", "));

            //this.programas=list;
            string separador = ", ";
            this.programas.AddRange(programas.Split(separador));
        }


    }
}
