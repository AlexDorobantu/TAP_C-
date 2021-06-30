using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Map2
    {

        public static List<T> map<T>(List<T> list, Func<T, T> f)
        {
            List<T> result = new List<T>();
            foreach (T elem in list)
            {
                result.Add(f.Invoke(elem));
            }

            return result;
        }

        public static void Main(String[] args)
        {
            List<string> elems = new List<string>();
            elems.Add("tap");
            elems.Add("lp");
            List<string> result = Map2.map(elems, (string p) => p.ToUpper());


            foreach (string elem in result)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
