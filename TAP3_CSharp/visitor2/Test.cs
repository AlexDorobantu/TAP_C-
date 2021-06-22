using System;

namespace visitor2
{
    class Test
    {
        static void Main(string[] args)
        {
            ComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
