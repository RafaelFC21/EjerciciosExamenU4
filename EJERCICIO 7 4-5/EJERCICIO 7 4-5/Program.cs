using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar raiz arbol
            Nodo raiz = new Nodo();
            raiz.ID = "Raiz";
            //Ingresar arbol
            Nodo Empty1 = new Nodo();
            Nodo Empty2 = new Nodo();
            Nodo Empty3 = new Nodo();
            Nodo Empty4 = new Nodo();
            Nodo Empty5 = new Nodo();
            Nodo Empty6 = new Nodo();
            Nodo Empty7 = new Nodo();
            Nodo a = new Nodo();
            a.ID = "a";
            Nodo e = new Nodo();
            e.ID = "e";
            Nodo i = new Nodo();
            i.ID = "i";
            Nodo k = new Nodo();
            k.ID = "k";
            Nodo o = new Nodo();
            o.ID = "o";
            Nodo p = new Nodo();
            p.ID = "p";
            Nodo u = new Nodo();
            u.ID = "u";
            //Enlazar arbol
            raiz.Left = Empty1;
            raiz.Right = Empty3;
            Empty1.Left = Empty2;
            Empty1.Right = i;
            Empty2.Left = a;
            Empty2.Right = e;
            Empty3.Right = Empty4;
            Empty4.Left = Empty5;
            Empty4.Right = Empty6;
            Empty5.Left = k;
            Empty5.Right = o;
            Empty6.Right = Empty7;
            Empty7.Left = p;
            Empty7.Right = u;
            //Buscar las rutas de cada nodo
            a.Search(raiz, "a");
            e.Search(raiz, "e");
            i.Search(raiz, "i");
            k.Search(raiz, "k");
            o.Search(raiz, "o");
            p.Search(raiz, "p");
            u.Search(raiz, "u");
            Console.ReadKey();
        }
    }
}
