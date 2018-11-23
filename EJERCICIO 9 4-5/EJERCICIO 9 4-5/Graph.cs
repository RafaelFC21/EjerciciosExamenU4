using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_9_4_5
{
    class Graph
    {
        private int vertex; //Numero de vertices
        private List<int>[] adyacency; //Declaración de lista de adyacencia
        List<string> Letter = new List<string>();


        public Graph(int num) //Constructor
        {
            Fill();
            vertex = num;
            adyacency = new List<int>[vertex];
            for (int cont = 0; cont < num; cont++)
            {
                adyacency[cont] = new List<int>();
            }
        }

        void Fill()//Se llena la lista
        {
            Letter.Add("A");
            Letter.Add("B");
            Letter.Add("C");
            Letter.Add("D");
            Letter.Add("E");
            Letter.Add("F");
            Letter.Add("G");
            Letter.Add("H");
            Letter.Add("I");
        }

        public void Connection(int vector1, int vector2) //Metodo para dar dirección a una conexión
        {
            adyacency[vector1].Add(vector2);
        }

        Graph Reverse() //Metodo que nos da la raiz al reves
        {
            Graph Reversed = new Graph(vertex);
            for (int contVector = 0; contVector < vertex; contVector++)
            {
                foreach (int item in adyacency[contVector]) //Por cada objeto dentro de la lista de adyacencia
                {
                    Reversed.Connection(item, contVector); 
                }
            }
            return Reversed; //regresa el grafo al reves
        }

        void ImprimirEnProfundidad(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(Letter[vertex] + " ");

            foreach (int item in adyacency[vertex]) 
            {
                if (visited[item] == false) //Si aun no lo visita lo imprime se repite el metodo
                {
                    ImprimirEnProfundidad(item, visited);
                }
            }
        }

        void FillStack(int vertex, bool[] visited, Stack<int> item) //Metodo para llenar una pila
        {
            visited[vertex] = true;

            foreach (int item2 in adyacency[vertex])
            {
                if (visited[item2] == false)
                {
                    FillStack(item2, visited, item); //Si aun no lo visita lo imprime se repite el metodo
                }
            }

            item.Push(vertex);
        }

        public void Print() //Metodo para imprimir los metodos fuertemente conexos
        {
            Stack<int> stack = new Stack<int>(); //pila donde se guardan los elementos

            bool[] visited = new bool[vertex];

            for (int cont = 0; cont < vertex; cont++)
            {
                visited[cont] = false;
            }

            for (int cont = 0; cont < vertex; cont++)
            {
                if (visited[cont] == false)
                {
                    FillStack(cont, visited, stack); //Si no ha visitado el vertice en cuestion se llama para que llene la pila donde se almacenan los vertices
                }
            }

            Graph graph = Reverse(); //Nos da el grafo al revez

            for (int cont = 0; cont < vertex; cont++)
            {
                visited[cont] = false; //Pone el visitado en false
            }

            while (stack.Count > 0) //Mientras que la pila tenga mas que 0 elementos
            {
                int item = stack.Pop(); //Elimina un elemento de la lista

                if (visited[item] == false) //Si el visitado es falso
                {
                    graph.ImprimirEnProfundidad(item, visited); //Imprime
                    Console.WriteLine();
                }
            }
        }
    }
}
