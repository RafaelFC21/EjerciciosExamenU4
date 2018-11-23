using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7_4_5
{
    class Nodo
    {   //Propiedades de la clase:
        public string ID { get; set; }
        public Nodo Left { get; set; }
        public Nodo Right { get; set; }
        public string route;

        public Nodo() //Constructor
        {
            this.ID = "-";
            this.Left = null;
            this.Right = null;
        }

        public void Search(Nodo actualNode, string data)
        {
            if (actualNode != null)//Si el nodo elegido no es inexistente
            {
                if (actualNode.Left != null || actualNode.Right != null)//Se verifica que no sea una hoja y si lo es se busca.
                {
                    
                    route = route + "0 ";//Si la ruta va a la izquierda toma valor 0
                    Search(actualNode.Left, data);
                    route = route + "1 ";//Si la ruta va a la derecha toma valor 1
                    Search(actualNode.Right, data);
                    if (route.Length >= 2)//Si la el tamaño de la ruta es mayor o igual a 2 remueve el valor que tiene en -2 veces el tamaño de la ruta
                        route = route.Remove(route.Length - 2);
                }
                else if (actualNode.ID == data)//Si el dato es el deseado se despliega
                {   
                    Console.WriteLine("Ruta " + data + ": " + route);
                }
                else
                    route = route.Remove(route.Length - 2);
            }
            else //Si no se cancela la ultima decisión.
                route = route.Remove(route.Length - 2);

        }
    }
}
