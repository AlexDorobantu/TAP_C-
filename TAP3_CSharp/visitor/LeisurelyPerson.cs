using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    public class LeisurelyPerson : Person
    {
        private int smile;  // how big is his smile

        public LeisurelyPerson(int smile) : base()
        {
            this.smile = smile;
        }

        public void Accept(TaxiVisitor v)
        {
            v.Visit(this);
        }

        public bool BigSmile()
        {
            return (this.smile > 5);
        }
    }
}
