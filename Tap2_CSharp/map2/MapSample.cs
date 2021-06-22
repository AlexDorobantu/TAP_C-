using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class MapSample
    {

        public static void Main(String[] args)
        {
            LinkedList<int> list = Arrays.asList(1, 3, 5, 7, 9);
            List<String> list2 = Arrays.asList("pedro", "lenguajes", "programacion", "Java", "haskell");
           
            List<int> result = Map.map(list, new Increment());
            
            foreach (int elem in result)
            {
                Console.WriteLine(elem);
            }

            result = Map.map(list, new Square());
            foreach (int elem in result)
            {
                Console.WriteLine(elem);
            }

            List<String> result2 = Map.map(list2, new Capitals());
            foreach (String elem in result2)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
