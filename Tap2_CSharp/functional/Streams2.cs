using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace functional
{
    class Streams2
    {

        public static void Main(String[] args)
        {
            List<Animal> people = new List<Animal>();
            Animal a1 = new Animal("loro", 24);
            Animal a2 = new Animal("oso", 75);
            Animal a3 = new Animal("gato", 16);
            Animal a4 = new Animal("perro", 6);
            Animal a5 = new Animal("elefante", 67);
            Animal a6 = new Animal("mamut", 81);
            
            people.Add(a1);
            people.Add(a2);
            people.Add(a3);
            people.Add(a4);
            people.Add(a5);
            people.Add(a6);



            List<string> list = people.Select(x => x.GetName()).ToList();


            int total = people.Select(x => x.GetAge()).Count();   
            Console.WriteLine(("cnt:" + total));


            List<Animal> ordered = people.OrderBy(x => x.GetName()).ToList();
            Console.WriteLine(("sorted:" + ordered));

        }

    }
}
