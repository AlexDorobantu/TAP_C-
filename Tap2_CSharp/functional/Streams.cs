using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Streams
    {

        public static void Main(String[] args)
        {
            LinkedList<Animal> list = new LinkedList<Animal>();
            Animal a1 = new Animal("loro", 24);
            Animal a2 = new Animal("oso", 75);
            Animal a3 = new Animal("gato", 16);
            Animal a4 = new Animal("perro", 6);
            Animal a5 = new Animal("elefante", 67);
            Animal a6 = new Animal("mamut", 81);
            list.AddLast(a1);
            list.AddLast(a2);
            list.AddLast(a3);
            list.AddLast(a4);
            list.AddLast(a5);
            list.AddLast(a6);

            Stream<Animal> animalsOver3 = list.stream().filter(p, -, Greater, (p.getAge() > 30));
            animalsOver3.forEach(elem, -, Greater, System.out.println(elem.getAge()));

           
            List<Animal> result = list.stream().filter(p, -, Greater, (p.getAge() > 30)).collect(Collectors.toList());
            result.forEach(System.out, :, :, println);
            
            
            long number = list.stream().filter(p, -, Greater, (p.getAge() > 30)).collect(Collectors.counting());
            System.out.println(("number " + number));
            
            
            list.stream().filter(p, -, Greater, (p.getAge() > 30)).count();

        }
}
