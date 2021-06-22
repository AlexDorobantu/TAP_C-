using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Test
    {

        public static void Main(String[] args)
        {
            LinkedList<Animal> list = new LinkedList<Animal>();
            Animal a1 = new Animal("a", 3);
            Animal a2 = new Animal("b", 7);
            Animal a3 = new Animal("c", 1);
            list.AddLast(a1);
            list.AddLast(a2);
            list.AddLast(a3);

            foreach (var value in list)
            {
                value.Talk();
            }


            foreach (var value in list)
            {
                Console.WriteLine();
            }

        }

    }
}
