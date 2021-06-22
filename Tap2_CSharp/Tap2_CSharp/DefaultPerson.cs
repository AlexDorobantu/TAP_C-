using System;
using System.Collections.Generic;
using System.Text;

namespace defaultmethods
{
    public class DefaultPerson : IPerson
    {
        public void SayHello()
        {
            Console.WriteLine("HELLO!");
        }
    }
}
