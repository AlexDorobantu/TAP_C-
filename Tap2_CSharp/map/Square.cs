using System;
using System.Collections.Generic;
using System.Text;

namespace map
{
    public class Square : IMap
    {

        public int Apply(int elem)
        {
            return (elem * elem);
        }
    }
}
