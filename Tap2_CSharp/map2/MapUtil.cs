using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class MapUtil
    {
        public static List<T> map<T>(List<T> list, Imap<T> function)
        {
            List<T> result = new List<T>();
            foreach (T elem in list)
            {
                result.Add(function.Apply(elem));
            }

            return result;
        }
    }
}
