using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class Castings
    {
        public static void Main(String[] args)
        {
            Object o1 = new Thing();
            Bop b = (Bop)o1;
            b.Dance();
            Musician m = (Musician)o1;
            m.Sing();
            Musician m2 = (Musician)b;
            b.Dance();
        }
    }
}
