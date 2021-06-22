using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class MapUtil
    {
        public static LinkedList<T> map<T>(List<T> list, Imap<T> function)
        {
            LinkedList<T> result = new LinkedList<T>();
            foreach (T elem in list)
            {
                result.AddLast(function.Apply(elem));
            }

            return result;
        }
    }
}
