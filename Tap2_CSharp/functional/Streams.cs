using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace functional
{
    public class Streams
    {

        public static void Main(String[] args)
        {
            List<Animal> list = new List<Animal>();
            Animal a1 = new Animal("loro", 24);
            Animal a2 = new Animal("oso", 75);
            Animal a3 = new Animal("gato", 16);
            Animal a4 = new Animal("perro", 6);
            Animal a5 = new Animal("elefante", 67);
            Animal a6 = new Animal("mamut", 81);
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            list.Add(a4);
            list.Add(a5);
            list.Add(a6);


            List<Animal> animalsOver3 = list.FindAll(x => x.GetAge() > 30);
            foreach (Animal elem in animalsOver3)
            {
                Console.WriteLine(elem.GetAge());
            }


            long number = list.FindAll(x => x.GetAge() > 30).Count();
            Console.WriteLine(("number " + number));

            list.Where(x => x.GetAge() > 30).Count();

        }
    }
}
