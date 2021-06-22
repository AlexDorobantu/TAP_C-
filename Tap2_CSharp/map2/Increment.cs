using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class Increment : Imap<int>
    {
        public int Apply(int elem)
        {
            return (elem + 1);
        }
    }
}
