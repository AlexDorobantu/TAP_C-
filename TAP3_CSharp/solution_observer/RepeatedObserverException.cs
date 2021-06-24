using System;
using System.Collections.Generic;
using System.Text;

namespace observer1
{
    public class RepeatedObserverException : Exception
    {

        public RepeatedObserverException() :
                base()
        {
        }

        public RepeatedObserverException(String message) :
                base(message)
        {
        }
        }

}
