using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class ReceivedState : PackageState
    {

        public void Next(Package pkg)
        {
            Console.WriteLine("This package is already received by a client.");
        }

        public void Prev(Package pkg)
        {
            pkg.SetState(new DeliveredState());
        }

        public void PrintStatus()
        {
            Console.WriteLine("Package was received by client.");
        }


        public String ToString()
        {
            return "ReceivedState{}";
        }
    }
}
