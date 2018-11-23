using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar raiz arbol 1
            Nodo raiz = new Nodo();
            raiz.ID = -1;
            //Se ingresar datos al arbol por el metodo ingresar
            raiz.Ingresar(raiz, 0);
            raiz.Ingresar(raiz, 2);
            raiz.Ingresar(raiz, -2);
            raiz.Ingresar(raiz, 3);
            raiz.Ingresar(raiz, 6);
            raiz.Ingresar(raiz, -3);
            raiz.Ingresar(raiz, 5);
            raiz.Ingresar(raiz, 1);
            raiz.Ingresar(raiz, 4);
            Console.WriteLine("Arbol 1:");
            raiz.inorden(raiz);//Se llama al metodo inorden

            //Se ingresar datos al arbol por el metodo ingresar
            Nodo raiz2 = new Nodo();
            raiz2.ID = -1;
            //Se ingresar datos al arbol por el metodo ingresar
            raiz.Ingresar(raiz, 7);
            raiz.Ingresar(raiz, 4);
            raiz.Ingresar(raiz, 11);
            raiz.Ingresar(raiz, 5);
            raiz.Ingresar(raiz, -8);
            raiz.Ingresar(raiz, 15);
            raiz.Ingresar(raiz, -3);
            raiz.Ingresar(raiz, -2);
            raiz.Ingresar(raiz, 6);
            raiz.Ingresar(raiz, 10);
            raiz.Ingresar(raiz, 3);
            Console.WriteLine("\nArbol 2:");
            raiz.inorden(raiz); //Se llama al metodo inorden
            Console.ReadKey();
        }
    }
}
