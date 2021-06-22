using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class UseThing2
    {
        public static void Main(string[] args)
        {
            Cat g = new Cat(1, 2);
            Thing2<Cat> c = new Thing2<Cat>(g);
            c.SetName(g);
            Cat g2 = c.GetName();
            Animal a = c.GetName();
            Console.WriteLine(g2.Talk());
            Console.WriteLine(a.Talk());

            //     Cosa2<string> c = new Cosa2<string>("www");  //ILEGAL !!
        }
    }
}
