using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_10_4_5
{
    class Nodo
    {
        public char node;
    }

    public class Grafo
    {
        Nodo start, route, newNode; //Se crean los objetos de la clase Nodos
        int path;
        bool final = false; 
        public Grafo() //Constructor clase grafo
        {
            start = null;
        }

        public void Vertex(char letter) //Método que recibe como parámetro la letra perteneciente al vertice
        {
            newNode = new Nodo();
            newNode.node = letter; 
            if (start == null)
                start = newNode;
            else
            {
                route = start;    
                if (newNode.node == start.node) //Si el vertice actual es igual al inicial
                {
                    final = false; //Final se hace falso
                }
                else if (route.node != newNode.node) //Si no es igual al inicial
                {
                    path++; //Se incrementa la longitud del camino
                    final = true;
                }
            }
        }

        public void CheckPath()
        {
            if (final) //Si final es verdadero
            {
                Console.WriteLine("El camino es simple"); 
                Console.WriteLine("La longitud de camino es: " + path); 
            }
            else
                Console.WriteLine("Es un circuito"); //Al no ser verdadero el final este es un circuito

        }
    }
}
