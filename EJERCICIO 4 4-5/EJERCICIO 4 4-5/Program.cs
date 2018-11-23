using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();//Se crea objeto de la clase Nodo.
            raiz.ID = "banana";//Se introducen los valores del arbol con raiz definida.
            raiz.Ingresar(raiz, "melocoton");
            raiz.Ingresar(raiz, "manzana");
            raiz.Ingresar(raiz, "pera");
            raiz.Ingresar(raiz, "coco");
            raiz.Ingresar(raiz, "mango");
            raiz.Ingresar(raiz, "papaya");
            Console.WriteLine("Arbol:");
            raiz.Desplegar(raiz);//Se imprime el arbol
            Console.ReadKey();
        }
    }
}
