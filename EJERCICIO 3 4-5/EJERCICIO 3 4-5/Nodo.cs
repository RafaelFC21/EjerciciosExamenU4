using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3_4_5
{
    public class Nodo
    {
        public int info; //Guarda el valor que toma el nodo
        public Nodo izq, der; //Punteros izquierda y derecha
        public char letra; //Letra del nodo
    }

    public class Arbol
    {
        Nodo raiz; //Se crea el objeto raiz

        public Arbol()
        {
            raiz = null; //El constructor inicializa raiz en nulo
        }

        public void Insertar(int info, char letra)
        {
            Nodo nuevo;
            nuevo = new Nodo(); //Se inicializa nuevo de parte de Nodo
            nuevo.info = info; //Se agrega el valor al nodo
            nuevo.letra = letra; //Se agrega la letra al nodo
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo; //Si raiz es nulo, se le asigna el primer valor ingresado
            else //De lo contrario se evaluan los valores de los nodos para ir acomodandolos
            {
                Nodo anterior = null, recorrido;
                recorrido = raiz;
                while (recorrido != null)
                {
                    anterior = recorrido;
                    if (info < recorrido.info)
                        recorrido = recorrido.izq;
                    else
                        recorrido = recorrido.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            } 
        }
        private void ImprimirPost(Nodo recorrido) //Se imprime el post-orden
        {
            if (recorrido != null)
            {
                ImprimirPost(recorrido.izq);
                ImprimirPost(recorrido.der);
                Console.Write(recorrido.letra + " ");
            }
        }
        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
