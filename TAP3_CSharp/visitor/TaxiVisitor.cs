using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    public interface TaxiVisitor
    {
        void Visit(HastyPerson e);

        void Visit(LeisurelyPerson e);
    }
}
