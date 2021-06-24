using System;

namespace bstree2
{
    class Program
    {
        public static void Main(String[] args)
        {
            BSTree<int> arbol = new BSTree<int>();
            arbol.Insert(5);
            arbol.Insert(3);
            arbol.Insert(6);
            arbol.Insert(1);
            arbol.Insert(4);
            Console.WriteLine(arbol.Contains(4));
            Console.WriteLine(arbol.Contains(8));

            foreach (int elem in arbol)
            {
                Console.WriteLine(elem);
            }

        }
    }

}
