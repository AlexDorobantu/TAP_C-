using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Filter
    {

        public static List<T> filter<T>(List<T> list, Predicate<T> f)
        {
            List<T> result = new List<T>();
            foreach (T elem in list)
            {
                if (f.Invoke(elem))
                {
                    result.Add(elem);
                }

            }
            return result;
        }

        public static void Main(string[] args)
        {
            List<string> elems = new List<string>();
            elems.Add("tap");
            elems.Add("lp");
            elems.Add("ptap");
            elems.Add("lp");
            
            List<string> result = elems.FindAll(e => e.StartsWith("p"));

            foreach (String elem in result)
            {
                Console.WriteLine(elem);
            }

            result = Filter.filter(elems, (String p) => p.StartsWith("p"));
            foreach (String elem in result)
            {
                Console.WriteLine(elem);
            }
        }

    }
}
