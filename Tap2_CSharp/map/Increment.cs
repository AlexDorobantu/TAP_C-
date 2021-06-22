using System;
using System.Collections.Generic;
using System.Text;

namespace map
{
    public class Increment : IMap
    {
        public int Apply(int elem)
        {
            return (elem + 1);
        }
    }
}
