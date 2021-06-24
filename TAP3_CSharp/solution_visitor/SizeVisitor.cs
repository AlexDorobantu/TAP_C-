using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public class SizeVisitor : Visitor
    {

        private int size = 0;

        public int GetSize()
        {
            return this.size;
        }

        public override void Visit(File file)
        {
            this.size = (this.size + file.GetSize());
        }
    }
}
