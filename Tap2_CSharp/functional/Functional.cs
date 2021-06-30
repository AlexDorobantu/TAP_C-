using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Functional
    {
        public static void Main(string[] args)
        {
            Action<int> c = (x) => Console.WriteLine(x);


            Action<int, string> b = (x, y) => Console.WriteLine(x + " : " + y);


            Predicate<string> p = (s) => s.Equals("TAP");

            Action<int> f = (elem) => elem = (elem + 1);


            Console.WriteLine(p.Invoke("TAP"));
            Console.WriteLine(p.Invoke("JO"));
            c.Invoke(4566);
            b.Invoke(666, "pedro");
            Console.WriteLine(f.DynamicInvoke(45));
        }
    }
}
