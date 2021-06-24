using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace structures
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var c;

            c = new List<string>();
            test(c);
            c = new LinkedList<string>();
            test(c);
            c = new HashSet<string>();
            test(c);
            c = new Stack<string>();
            test(c);
        }

        public static void test(Collection<string> c)
        {
            string[] strings = new string[] {
                "uno",
                "dos",
                "tres",
                "cuatro",
                "tres"};

            foreach (string num in strings)
            {
                c.Add(num);
            }

            foreach (String num in c)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------------------------");
        }
    }
}
