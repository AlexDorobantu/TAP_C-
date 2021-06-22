using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class OrderedState : PackageState
    {

        public void Next(Package pkg)
        {
            pkg.SetState(new DeliveredState());
        }

        public void Prev(Package pkg)
        {
            Console.WriteLine("The package is in it\'s root state.");
        }

        public void PrintStatus()
        {
            Console.WriteLine("Package ordered, not delivered to the office yet.");
        }

        public String ToString()
        {
            return "OrderedState{}";
        }
    }
}
