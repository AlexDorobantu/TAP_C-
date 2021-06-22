using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    public class Parrot : Animal
    {
        public Parrot(int legs, int eyes) : base(legs, eyes) {}

        //  Refinement
        public String Talk => ("I am a parrot and " + base.Talk);
    }
}
