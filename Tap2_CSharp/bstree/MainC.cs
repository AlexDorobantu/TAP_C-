using System;
using System.Collections.Generic;
using System.Text;

namespace bstree
{
    public class MainC
    {

        public static void Main(String[] args)
        {
            BSTree<int> arbol = new BSTree<int>(new Comparaint());
            arbol.insert(5);
            arbol.insert(3);
            arbol.insert(6);
            arbol.insert(1);
            arbol.insert(4);
            Console.WriteLine(arbol.contains(4));
            Console.WriteLine(arbol.contains(8));
            foreach (int elem in arbol)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
