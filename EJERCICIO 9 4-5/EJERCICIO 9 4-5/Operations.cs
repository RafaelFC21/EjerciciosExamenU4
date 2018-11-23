using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_9_4_5
{
    class Operations
    {
        Graph graph1 = new Graph(5);
        Graph graph2 = new Graph(6);
        Graph graph3 = new Graph(9);

        public Operations()
        {
            FillGraph();
        }

        void FillGraph()
        {
            //Primer grafo
            graph1.Connection(0, 4);
            graph1.Connection(4, 1);
            graph1.Connection(1, 0);
            graph1.Connection(1, 2);
            graph1.Connection(3, 4);
            graph1.Connection(3, 1);
            graph1.Connection(3, 2);
            //Segundo grafo
            graph2.Connection(0, 5);
            graph2.Connection(1, 0);
            graph2.Connection(2, 1);
            graph2.Connection(2, 3);
            graph2.Connection(3, 4);
            graph2.Connection(4, 2);
            graph2.Connection(4, 5);
            //Tercer grafo
            graph3.Connection(0, 8);
            graph3.Connection(0, 2);
            graph3.Connection(1, 0);
            graph3.Connection(1, 7);
            graph3.Connection(1, 2);
            graph3.Connection(3, 2);
            graph3.Connection(3, 4);
            graph3.Connection(3, 1);
            graph3.Connection(4, 3);
            graph3.Connection(5, 3);
            graph3.Connection(5, 6);
            graph3.Connection(5, 4);
            graph3.Connection(6, 2);
            graph3.Connection(6, 3);
            graph3.Connection(7, 5);
            graph3.Connection(7, 6);
            graph3.Connection(7, 8);
            graph3.Connection(8, 0);
            graph3.Connection(8, 6);
        }

        public void Start()
        {
            Console.WriteLine("Fuertemente conexos grafo 1: ");
            graph1.Print();
            Console.WriteLine("Fuertemente conexos grafo 2: ");
            graph2.Print();
            Console.WriteLine("fuertemente conexos grafo 3: ");
            graph3.Print();
            Console.ReadKey();
        }
    }
}
