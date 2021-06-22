using System;

namespace state
{
    class StateDemo
    {
        public static void Main(string[] args)
        {
            Package pkg = new Package();
            pkg.PrintStatus();
            pkg.NextState();
            pkg.PrintStatus();
            pkg.NextState();
            pkg.PrintStatus();
            pkg.NextState();
            pkg.PrintStatus();
        }
    }
}
