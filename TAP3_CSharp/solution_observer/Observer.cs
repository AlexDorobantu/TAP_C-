using System;
using System.Collections.Generic;
using System.Text;

namespace observer1
{
    public interface Observer<T>
    {
        void NotifyAdd(T elem);
        void NotifyRemove(T elem);
    }
}
