using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public class Capitals : Imap<string>
    {
        public string Apply(string elem)
        {
            return elem.ToUpper();
        }
    }
}
