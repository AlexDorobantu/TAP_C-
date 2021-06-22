using System;
using System.Collections.Generic;
using System.Text;

namespace map
{
    public class MapSample
    {
        public static void Main(String[] args)
        {
            int[] list = new int[] {1,2,3,4,5};

            int[] result = Map.map(list, new Increment());

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            int[] result2 = Map.map(list, new Square());
            foreach (int i in result2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
