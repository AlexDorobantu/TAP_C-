using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class MutantParrot : Parrot
    {

        public MutantParrot(int patas, int ojos) :
                base(patas, ojos)
        {
        }

        public string Vuela()
        {
            return "vuelo ...";
        }
    }
}
