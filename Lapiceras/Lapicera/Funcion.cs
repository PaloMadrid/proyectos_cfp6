using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Funcion
    {
        public static bool validarString(string dato)
        {
            bool retorno = false;

            if (string.IsNullOrEmpty(dato))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool validarColor(Color dato)
        {
            bool retorno = false;

            if (dato.IsEmpty)
            {
                retorno = true;
            }

            return retorno;
        }

        public static int ContarCaracteres(string dato)
        {
            int cantidad = 0;

            foreach (char c in dato)
            {
                if (!char.IsWhiteSpace(c))
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        public static bool EsNumerico(string dato)
        {
            bool esNumerico = true;
            foreach (char c in dato)
            {
                if (char.IsDigit(c))
                {
                    esNumerico = false;
                }
            }
            return esNumerico;
        }

        public static bool EsSoloLetras(string dato)
        {
            bool esSoloLetras = true;

            foreach (char c in dato)
            {
                if (!char.IsLetter(c))
                {
                    esSoloLetras = false;
                }
            }
            return esSoloLetras;
        }

    }
}
