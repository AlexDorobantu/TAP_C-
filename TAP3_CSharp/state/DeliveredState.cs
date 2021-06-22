using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class DeliveredState : PackageState
    {

        public void Next(Package pkg)
        {
            pkg.SetState(new ReceivedState());
        }

        public void Prev(Package pkg)
        {
            pkg.SetState(new OrderedState());
        }

        public void PrintStatus()
        {
            Console.WriteLine("Package delivered to post office, not received yet.");
        }

        public String ToString()
        {
            return "DeliveredState{}";
        }
    }
}
