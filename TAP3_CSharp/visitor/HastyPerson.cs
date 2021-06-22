using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    public class HastyPerson : Person
    {
        private int clockFrequency;

        // how often he looks at his clock
        public HastyPerson(int clockFrequency) :
                base()
        {
            this.clockFrequency = clockFrequency;
        }

        public void Accept(TaxiVisitor v)
        {
            v.Visit(this);
        }

        public bool VeryHasty()
        {
            return (this.clockFrequency > 4);
        }
    }
}
