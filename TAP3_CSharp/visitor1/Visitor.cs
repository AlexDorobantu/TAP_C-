using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public abstract class Visitor
    {
        public abstract void Visit(File file);

        public void Visit(Directory dir)
        {
            foreach (AComponent elem in dir.GetChildren())
            {
                elem.Accept(this);
            }

        }
    }
}
