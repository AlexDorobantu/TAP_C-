using System;
using System.Collections.Generic;
using System.Text;


namespace structures
{
    public class AgeComparator : IComparer<Client>
    {

        public int Compare(Client p1, Client p2)
        {
            int s1 = p1.GetAge();
            int s2 = p2.GetAge();

            if ((s1 > s2))
            {
                return 1;
            }
            else if ((s1 < s2))
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
