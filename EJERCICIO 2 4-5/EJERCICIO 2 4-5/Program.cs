using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos EnviarCartas = new Datos();
            EnviarCartas.Ingresar(5);
            EnviarCartas.ObtenerCartas(5);
            EnviarCartas.CartasTotales();
            EnviarCartas.Finales();
            Console.ReadKey();
        }
    }
}
