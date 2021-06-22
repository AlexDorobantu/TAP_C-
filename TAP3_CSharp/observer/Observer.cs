using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public abstract class Observer
    {
        public abstract void Update(int newValue);
    }
}
