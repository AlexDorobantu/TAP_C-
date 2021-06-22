using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    public class Cat : Animal
    {
        public Cat(int legs, int eyes) : base(legs, eyes) { }

        //  Inheritance with replacement method
        public String Talk => "I\'m a cat";
    }
}
