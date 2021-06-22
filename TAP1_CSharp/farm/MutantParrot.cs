using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    public class MutantParrot : Parrot
    {
        public MutantParrot(int legs, int eyes) :
            base(legs, eyes)
        {

        }

        public String fly()
        {
            return "I\'m flying ...";
        }
    }
}
