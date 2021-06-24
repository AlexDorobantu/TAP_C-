using System;
using System.Collections.Generic;
using System.Text;

namespace structures
{
    public class NameComparator : IComparer<Client>
    {
        public int Compare(Client p1, Client p2)
        {
            String s1 = p1.GetName();
            String s2 = p2.GetName();
            return s1.CompareTo(s2);
        }
    }
}
