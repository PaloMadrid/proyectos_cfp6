using Librerias;

namespace Testeo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco cuenta1 = new Banco("Juan", "Caja de ahorro", 100000);
            int retorno;
            int dinero;
            bool bandera = false;

            Console.WriteLine(cuenta1.CuentaToString());
                       
            do
            {
                Console.WriteLine("Que operacion desea hacer?");
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Ver informacion de la cuenta");
                Console.WriteLine("4. Salir");
                retorno = int.Parse(Console.ReadLine());

                switch (retorno)
                {
                    case 1:
                        Console.WriteLine("Monto a depositar:");
                        dinero = int.Parse(Console.ReadLine());
                        cuenta1.IngresarDinero(dinero);
                        break;
                    case 2:
                        Console.WriteLine("Monto a retirar");
                        dinero = int.Parse(Console.ReadLine());
                        cuenta1.RetirarDinero(dinero);
                        break;
                    case 3:
                        Console.WriteLine(cuenta1.CuentaToString());
                        break;
                    case 4:
                        bandera = true;
                        break;
                    default:
                        Console.WriteLine("Escriba el numero de la lista correspondiente a la accion que quiera hacer");
                        break;
                }

            } while (!bandera);


        }
    }
}
