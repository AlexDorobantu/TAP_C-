using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class Capitals : Imap<string>
    {
        public String Apply(String elem)
        {
            return elem.ToUpper();
        }
    }
}
