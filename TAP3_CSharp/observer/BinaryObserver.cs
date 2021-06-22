using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class BinaryObserver : Observer
    {

        public override void Update(int newState)
        {
            Console.WriteLine(("Binary String: " + Integer.toBinaryString(newState)));
        }
    }
}
