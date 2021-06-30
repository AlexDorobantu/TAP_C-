using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class MapSample
    {

        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Add(9);

            List<string> list2 = new List<string>();
            list2.Add("pedro");
            list2.Add("lenguajes");
            list2.Add("programacion");
            list2.Add("haskell");
           
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
