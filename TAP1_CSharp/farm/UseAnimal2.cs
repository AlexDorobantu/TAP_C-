using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    public class UseAnimal2
    {
        public static void Main(String[] args)
        {
            //  Create animals
            Animal a = new Animal(3, 3);
            Cat g = new Cat(1, 2);
            MutantParrot lM = new MutantParrot(3, 3);

            //  Static list
            Animal[] farm = new Animal[3];
            farm[0] = a;
            farm[1] = g;
            farm[2] = lM;

            foreach (Animal ani in farm)
            {
                Console.WriteLine(ani.Talk);
            }

            //  Dynamic list
            LinkedList<Animal> lorry = new LinkedList<Animal>();
            lorry.AddLast(a);
            lorry.AddLast(g);
            lorry.AddLast(lM);
            //  New for
            foreach (Animal o in lorry)
            {
                Console.WriteLine(o.Talk);
            }

        }

    }
}
