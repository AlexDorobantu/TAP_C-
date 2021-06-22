using System;
using System.Collections.Generic;
using System.Text;

namespace visitor
{
    public class CorruptTaxiVisitor : TaxiVisitor
    {

        public void Visit(HastyPerson e)
        {
            if (e.VeryHasty())
            {
                Console.WriteLine("I drive slowly. Clink clink clink...");
            }
            else
            {
                Console.WriteLine("I drive very slowly. Clink clink clink...");
            }

        }

        public void Visit(LeisurelyPerson e)
        {
            if (e.BigSmile())
            {
                Console.WriteLine("I drive as slowly as I can. Clink clink clink...");
            }
            else
            {
                Console.WriteLine("I drive very slowly. Clink clink clink...");
            }

        }
    }
}
