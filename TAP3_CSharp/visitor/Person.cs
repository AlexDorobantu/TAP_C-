using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    public interface Person
    {
        void Accept(TaxiVisitor v);
    }
}
