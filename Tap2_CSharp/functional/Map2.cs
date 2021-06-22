using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Map2
    {

        public static LinkedList<T> map<T>(List<T> list, Function<T, T> f)
        {
            LinkedList<T> result = new LinkedList<T>();
            foreach (T elem in list)
            {
                result.AddLast(f.apply(elem));
            }

            return result;
        }

        public static void Main(String[] args)
        {
            LinkedList<String> elems = new LinkedList();
            elems.AddLast("tap");
            elems.AddLast("lp");
            List<String> result;
            p.toUpperCase();

            foreach (String elem in result)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
