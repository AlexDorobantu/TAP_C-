using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class Square : Imap<int>
    {
        public int Apply(int elem)
        {
            return (elem * elem);
        }
    }
}
