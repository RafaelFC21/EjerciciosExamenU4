using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_10_4_5
{
    class Pasos
    {//Enviamos los conjuntos de vertices
        public void Set1()
        {
            Grafo Send = new Grafo();

            Console.Write("Conjunto 1 ");

            Send.Vertex('a');
            Send.Vertex('b');
            Send.Vertex('e'); 
            Send.Vertex('c');
            Send.Vertex('b');
            Send.CheckPath(); //Comprueba si es o no un camino simple o si es un circuito
        }

        public void Set2()
        {
            Grafo Send = new Grafo();

            Console.Write("\nConjunto 2 ");

            Send.Vertex('a');
            Send.Vertex('d');
            Send.Vertex('a'); 
            Send.Vertex('d');
            Send.Vertex('a');
            Send.CheckPath(); //Comprueba si es o no un camino simple o si es un circuito
        }

        public void Set3()
        {
            Grafo Send = new Grafo();

            Console.Write("\nConjunto 3 ");

            Send.Vertex('a');
            Send.Vertex('d');
            Send.Vertex('b');
            Send.Vertex('e');
            Send.Vertex('a');
            Send.CheckPath(); //Comprueba si es o no un camino simple o si es un circuito
        }

        public void Set4()
        {
            Grafo Send = new Grafo();

            Console.Write("\nConjunto 4 ");

            Send.Vertex('a');
            Send.Vertex('b');
            Send.Vertex('e'); 
            Send.Vertex('c');
            Send.Vertex('b');
            Send.Vertex('d');
            Send.Vertex('a');
            Send.CheckPath(); //Comprueba si es o no un camino simple o si es un circuito
            Console.ReadKey();
        }
    }
}
