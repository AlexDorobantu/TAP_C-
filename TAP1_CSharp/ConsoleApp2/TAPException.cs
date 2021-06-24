using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TAPException : Exception
    {
        public TAPException(String message) :
                base(message)
        {
        }
    }
}
