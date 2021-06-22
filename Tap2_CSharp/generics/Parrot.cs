using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Parrot : Animal
    {

        public Parrot(int patas, int ojos) :
                base(patas, ojos)
        {
        }

        //  Refinamiento
        public string Talk()
        {
            return ("Soy un Loro y " + base.Talk());
        }
    }
}
