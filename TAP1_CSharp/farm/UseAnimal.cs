using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    public class UseAnimal
    {
        public static void main(String[] args)
        {
            Animal a = new Animal(3, 3);
            Dog p = new Dog(1, 1, true);
            Cat g = new Cat(1, 2);
            Parrot l = new Parrot(1, 2);
            MutantParrot lM = new MutantParrot(3, 3);


            Console.WriteLine("ANIMAL: " + a.Talk);
            Console.WriteLine("DOG: " + p.Talk);
            Console.WriteLine("CAT: " + g.Talk);
            Console.WriteLine("PARROT: " + l.Talk);
            Console.WriteLine("MUTANT PARROT:" + lM.Talk);


            a = p;
            Console.WriteLine("ANIMAL: " + a.Talk);


            a = lM;
            Console.WriteLine("ANIMAL: " + a.Talk);
        }


    }
}
