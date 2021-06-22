using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class OctalObserver : Observer
    {


        public override void Update(int newState)
        {
            Console.WriteLine(("Octal String: " + Convert.ToString(newState, 8)));
        }
    }
}
