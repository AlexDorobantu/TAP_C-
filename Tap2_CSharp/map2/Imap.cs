using System;
using System.Collections.Generic;
using System.Text;

namespace map2
{
    public interface Imap<T>
    {
        T Apply(T elem);
    }
}
