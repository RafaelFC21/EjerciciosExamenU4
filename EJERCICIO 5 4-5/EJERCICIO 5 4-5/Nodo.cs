using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_5_4_5
{
    class Nodo
    {   //Propiedades de la clase:
        public string ID { get; set; }
        public Nodo Left { get; set; }
        public Nodo Right { get; set; }

        public Nodo() //Constructor de la clase
        {   //Inicializa las propiedades
            this.ID = "";
            this.Left = null;
            this.Right = null;
        }

        public void Ingresar(Nodo raiz, string dato)
        {
            Nodo newNode = new Nodo();//Se inicializa el nuevo nodo
            newNode.ID = dato;
            Nodo pointer = raiz;
            int move = 0;
            int i = 0;

            byte[] dataBytes = Encoding.ASCII.GetBytes(dato);//Se genera un arreglo de bytes con los ascii por el cual mide el tamaño en bytes de las letras
            byte[] pointBytes = Encoding.ASCII.GetBytes(pointer.ID);

            int dataValue = dataBytes[0];
            int pointValue = pointBytes[0];

            while (move != 4)
            {
                pointBytes = Encoding.ASCII.GetBytes(pointer.ID);
                pointValue = pointBytes[0]; //Compara si la letra es igual.             
                while (dataValue == pointValue)//Si las letras son iguales va a seguir con la siguiente hasta que sea diferente.
                {
                    i++;
                    dataValue = dataBytes[i];
                    pointValue = pointBytes[i];
                }
                if (dataValue < pointValue) //Si el dato es de menor valor va a una dirección...
                    move = 1;
                else//Si no va a la segunda.
                    move = 2;

                switch (move)//Ingresar al nodo conectado a la izquierda/derecha del nodo actual
                {
                    case 1: //izquierda
                        if (pointer.Left != null) //Si existe el dato se transifiere a otro lugar
                            pointer = pointer.Left;
                        else //Si no entonces se queda.
                        {
                            pointer.Left = newNode;
                            move = 4;
                        }
                        break;
                    case 2: //derecha
                        if (pointer.Right != null) //Si existe el dato se transifiere a otro lugar
                            pointer = pointer.Right;
                        else  //Si no entonces se queda.
                        {
                            pointer.Right = newNode;
                            move = 4;
                        }
                        break;
                }
            }
        }

        public void Desplegar(Nodo actualNode)
        {
            if (actualNode != null) //Si todavia hay nodos el arbol se seguirá moviendo
            {   //Imprime el nodo actual
                Console.WriteLine("({1}) <- ({0}) -> ({2})", actualNode.ID, (actualNode.Left == null ? "null" : actualNode.Left.ID.ToString()), (actualNode.Right == null ? "null" : actualNode.Right.ID.ToString()));
                Desplegar(actualNode.Left);
                Desplegar(actualNode.Right);
            }
        }
    }
}
