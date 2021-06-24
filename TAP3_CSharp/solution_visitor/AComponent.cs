using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public interface AComponent
    {

        void Ls();
        List<AComponent> ToList();
        void SetParent(AComponent parent);

        void Accept(Visitor v);
    }
}
