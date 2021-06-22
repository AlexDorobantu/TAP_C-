using System;
using System.Collections.Generic;
using System.Text;

namespace visitor2
{
    public interface ComputerPart
    {
        void Accept(ComputerPartVisitor computerPartVisitor);
    }
}
