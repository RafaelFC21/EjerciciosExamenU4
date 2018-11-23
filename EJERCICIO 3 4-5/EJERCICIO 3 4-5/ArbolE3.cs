using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3_4_5
{
    class ArbolE3
    {
        public void LlamarArbol()
        {
            Arbol arbol = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol llamando al metodo insertar
            arbol.Insertar(11, 'A');
            arbol.Insertar(4, 'B');
            arbol.Insertar(16, 'C');
            arbol.Insertar(3, 'D');
            arbol.Insertar(5, 'E');
            arbol.Insertar(14, 'F');
            arbol.Insertar(20, 'G');
            arbol.Insertar(12, 'H');
            arbol.Insertar(15, 'I');
            arbol.Insertar(13, 'J');
            arbol.Insertar(30, 'K');
            Console.WriteLine("\nImpresion postorden: ");
            arbol.ImprimirPost();//Impresion del arbol en postorden
            Console.ReadKey();
        }
    }
}
