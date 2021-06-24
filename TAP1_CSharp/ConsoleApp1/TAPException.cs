using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TAPException : Exception
    {

        public TAPException(String message) :
                base(message)
        {
        }
    }
}
