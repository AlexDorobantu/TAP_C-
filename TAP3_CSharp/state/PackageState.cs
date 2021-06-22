using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public interface PackageState
    {
        void Next(Package pkg);

        void Prev(Package pkg);

        void PrintStatus();
    }
}
