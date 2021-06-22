using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Filter
    {

        public static List<T> filter<T>(List<T> list, Predicate<T> f)
        {
            LinkedList<T> result = new LinkedList<T>();
            foreach (T elem in list)
            {
                if (f.test(elem))
                {
                    result.Add(elem);
                }

            }
            return result;
        }

        public static void Main(String[] args)
        {
            LinkedList<String> elems = new LinkedList();
            elems.AddLast("tap");
            elems.AddLast("lp");
            elems.AddLast("ptap");
            elems.AddLast("lp");
            List<String> result;
            p.startsWith("p");
            foreach (String elem in result)
            {
                System.out.println(elem);
            }

        }

    }
}
