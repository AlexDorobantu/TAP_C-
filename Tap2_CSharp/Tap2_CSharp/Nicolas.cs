using System;
using System.Collections.Generic;
using System.Text;

namespace defaultmethods
{
    public class Nicolas : IPerson
    {
        public void SayHello()
        {
            Console.WriteLine("I am Nicolas, the young corrupt guy");
        }
    }
}
