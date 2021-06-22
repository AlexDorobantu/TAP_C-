using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class Thing : Musician, Bop
    {

        public string Dance()
        {
            return "LALALA";
        }

        public string Sing()
        {
            return "ouch...";
        }
    }
}
