using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8_4_5
{
    class Nodo
    {
        //Propiedades de la clase:
        public int ID { get; set; }
        public Nodo Left { get; set; }
        public Nodo Right { get; set; }

        public Nodo() //Constructor de la clase
        {   //Inicializa las propiedades
            this.ID = 0;
            this.Left = null;
            this.Right = null;
        }

        public void Ingresar(Nodo raiz, int dato)
        {
            Nodo newNode = new Nodo();//Se inicializa el nuevo nodo
            newNode.ID = dato;
            Nodo pointer = raiz;
            int move = 0;
            int i = 0;

            while (move != 4)
            {            
                if (newNode.ID < pointer.ID)//Se compara el nodo y se mueve dependiendo el resultado
                    move = 1;
                else
                    move = 2;
                switch (move)//Ingresar al nodo conectado a la izquierda/derecha del nodo actual
                {
                    case 1: //Si es izquierda
                        if (pointer.Left != null)
                            pointer = pointer.Left;
                        else //Si es inexistente se queda.
                        {
                            pointer.Left = newNode;
                            move = 4;
                        }
                        break;
                    case 2: //Si es derecha
                        if (pointer.Right != null)  
                            pointer = pointer.Right;
                        else  //Si es inexistente se queda.
                        {
                            pointer.Right = newNode;
                            move = 4;
                        }
                        break;
                }
            }
        }
        public void inorden(Nodo nodoActual)
        {
            if (nodoActual != null)
            {
                inorden(nodoActual.Left); //Se mueve a la izquierda
                Console.Write("({0})", nodoActual.ID); //Imprime el valor
                inorden(nodoActual.Right); //Se mueve a la derecha
            }
        }
    }
}
