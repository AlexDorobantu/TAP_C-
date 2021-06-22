using System;
using System.Collections.Generic;
using System.Text;

namespace visitor2
{
    public class Computer : ComputerPart
    {

        ComputerPart[] parts;

        public Computer()
        {
            this.parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor()};
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; (i < this.parts.Length); i++)
            {
                this.parts[i].Accept(computerPartVisitor);
            }

            computerPartVisitor.Visit(this);
        }
    }
}
