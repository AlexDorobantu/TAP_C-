using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class HexaObserver : Observer
    {


        public override void Update(int newState)
        {
            Console.WriteLine(("Hex String: " + Convert.ToString(newState, 16).ToUpperInvariant()));
        }
    }
}
