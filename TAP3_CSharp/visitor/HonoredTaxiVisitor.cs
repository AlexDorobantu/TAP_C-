using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    public class HonoredTaxiVisitor : TaxiVisitor
    {

        public void Visit(HastyPerson e)
        {
            if (e.VeryHasty())
            {
                Console.WriteLine("I drive as fast as I can");
            }
            else
            {
                Console.WriteLine("I drive fast");
            }

        }

        public void Visit(LeisurelyPerson e)
        {
            Console.WriteLine("I drive in a natural way");
        }
    }
}
