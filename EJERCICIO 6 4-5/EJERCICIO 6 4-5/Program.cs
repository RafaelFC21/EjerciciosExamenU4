using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_6_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();//Se crea objeto de la clase Nodo.
            raiz.ID = "El";//Se introducen los valores del arbol con raiz definida.
            raiz.Ingresar(raiz, "rapido");
            raiz.Ingresar(raiz, "zorro");
            raiz.Ingresar(raiz, "marron");
            raiz.Ingresar(raiz, "salta");
            raiz.Ingresar(raiz, "sobre");
            raiz.Ingresar(raiz, "el");
            raiz.Ingresar(raiz, "perro");
            raiz.Ingresar(raiz, "perezoso");
            Console.WriteLine("Arbol:");//Se imprime el arbol
            raiz.Desplegar(raiz);
            Console.ReadKey();
        }
    }
}
