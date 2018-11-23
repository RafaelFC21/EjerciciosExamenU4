using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_5_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();//Se crea objeto de la clase Nodo.
            raiz.ID = "enologia";//Se introducen los valores del arbol con raiz definida.
            raiz.Ingresar(raiz, "frenologia");
            raiz.Ingresar(raiz, "campanologia");
            raiz.Ingresar(raiz, "ornitologia");
            raiz.Ingresar(raiz, "ictilogia");
            raiz.Ingresar(raiz, "limnologia");
            raiz.Ingresar(raiz, "alquimia");
            raiz.Ingresar(raiz, "astrologia");
            Console.WriteLine("Arbol:");//Se imprime el arbol
            raiz.Desplegar(raiz);
            Console.ReadKey();
        }
    }
}
