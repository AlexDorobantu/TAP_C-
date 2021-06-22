using System;
using System.Collections.Generic;
using System.Text;

namespace defaultmethods
{
    public interface IPerson
    {
        public void SayHello();

        public void BlackCard()
        {
            Console.WriteLine("I have a black card");
        }
    }
}
