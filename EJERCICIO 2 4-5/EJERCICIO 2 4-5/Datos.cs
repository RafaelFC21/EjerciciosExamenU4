using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2_4_5
{
    class Datos
    {
        int contador = 0;
        double cartas = 0;
        double primeras = 0;
        Arbol Llamada = new Arbol();
        public void Ingresar(int valor)
        {
            if (contador < 7)
            {
                contador++;
                Llamada.Insertar(valor); //Se ingresan en el arbol los valores
                Ingresar(valor);
            }
        }

        public void ObtenerCartas(int valor)
        {

            for (int contador2 = 0; contador2 < Math.Pow(5, 6); contador2++) //Hace la suma de todas las cartas que se enviaron
            {
                cartas = cartas + valor;
            }

            for (int contador2 = 0; contador2 < Math.Pow(5, 3); contador2++) //Hace la suma de las primeras semanas, para posteriormente restarlas
            {
                primeras = primeras + valor;
            }
        }

        public void CartasTotales()
        {
            Console.WriteLine("Número de cartas enviadas: " + cartas * 2); //Se multiplica por 2 porque son 2 personas las que envian las cartas
        }

        public void Finales()
        {
            Console.WriteLine("Número de cartas enviadas los últimos 3 domingos: " + (cartas - primeras) * 2); //Se hace la diferencia
        }

    }
}
