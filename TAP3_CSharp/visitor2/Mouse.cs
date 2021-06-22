using System;
using System.Collections.Generic;
using System.Text;

namespace visitor2
{
    public class Mouse : ComputerPart
    {
        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
