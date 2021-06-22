using System;
using System.Collections.Generic;
using System.Text;

namespace map
{
    public class Map
    {
        public static int[] map(int[] lista, IMap function)
        {
            int[] result = new int[lista.Length];
            for (int i = 0; (i < lista.Length); i++)
            {
                result[i] = function.Apply(lista[i]);
            }

            return result;
        }
    }
}
