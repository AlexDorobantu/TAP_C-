using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class UseThing
    {
        public static void Main(string[] args)
        {
            Thing<string> cosa = new Thing<string>("pedro");
            string name = cosa.GetName();
            Console.WriteLine(name);
            //   cosa.setName(new Integer(7));  //ILEGAL !!
        }
    }
}
