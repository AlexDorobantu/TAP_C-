using System;
using System.Collections.Generic;
using System.Text;

namespace visitor2
{
    public class ComputerPartDisplayVisitor : ComputerPartVisitor
    {

        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
}
