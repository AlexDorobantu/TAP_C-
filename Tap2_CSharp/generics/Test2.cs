using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Test2
    {

        public static void Main(string[] args)
        {
            Animal a = new Animal(3, 3);
            Cat g = new Cat(1, 2);
            MutantParrot lM = new MutantParrot(3, 3);
            List<Animal> granja = new List<Animal>();
            granja.Add(a);
            granja.Add(g);
            granja.Add(lM);
            Test2.test(granja);
            Test2.test2(granja);
            Cat p = Test2.getParam(g);
        }

        public static void test(List<Animal> c)
        {
            foreach (Animal elem in c)
            {
                Console.WriteLine(elem.Talk());
            }

            Console.WriteLine("-------------------------");
        }

        public static void test2(LinkedList<Animal> c)
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
