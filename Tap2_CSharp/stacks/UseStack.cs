using System;
using System.Collections.Generic;
using System.Text;

namespace stacks
{
    public class UseStack
    {

        public static void Main(String[] args)
        {
            Stack<int> pila;

            int[] lista = new int[5];
            pila = new ArrayStack<int>(lista);
            pila.push(3000);
            pila.push(7000);
            pila.push(9000);

            foreach (int i in pila)
            {
                Console.WriteLine(i);
            }

            //     test(pila);

            pila = new VectorStack<int>(10);
            pila.push(3);
            pila.push(7);
            pila.push(9);

            foreach (int i in pila)
            {
                Console.WriteLine(i);
            }

            UseStack.test(pila);
        }

        public static void test(Stack<int> p)
        {
            int i = 0;
            while (!p.full())
            {
                p.push((10 * i));
                i++;
            }

            while (!p.empty())
            {
                Console.WriteLine(p.pop());
            }

        }

        public static void test2<T>(Stack<T> p)
        {
            while (!p.empty())
            {
                Console.WriteLine(p.pop());
            }

        }
    }
}
