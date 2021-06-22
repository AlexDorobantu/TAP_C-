using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Test2
    {

        public static void Main(String[] args)
        {
            Animal a = new Animal(3, 3);
            Cat g = new Cat(1, 2);
            MutantParrot lM = new MutantParrot(3, 3);
            LinkedList<Animal> granja = new LinkedList<Animal>();
            granja.AddLast(a);
            granja.AddLast(g);
            granja.AddLast(lM);
            Test2.test(granja);
            Test2.test2(granja);
            Cat p = Test2.getParam(g);
        }

        public static void test(Collection<Animal> c)
        {
            foreach (Animal elem in c)
            {
                Console.WriteLine(elem.Talk());
            }

            Console.WriteLine("-------------------------");
        }

        public static void test2<T, extends, Animal>(Collection<T> c)
        {
            foreach (Animal elem in c)
            {
                Console.WriteLine(elem.Talk());
            }

            Console.WriteLine("-------------------------");
        }

        public static T getParam<T, extends, Animal>(T elem)
        {
            return elem;
        }
    }
}
