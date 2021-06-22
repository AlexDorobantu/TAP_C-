using System;
using System.Collections.Generic;
using System.Text;

namespace defaultmethods
{
    public class DefaultTest
    {
        public static void Main(String[] args)
        {
            IPerson p = new DefaultPerson();
            p.SayHello();
            p.BlackCard();

        }

    }
}
