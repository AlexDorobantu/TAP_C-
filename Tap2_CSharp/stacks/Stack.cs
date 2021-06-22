using System;
using System.Collections.Generic;
using System.Text;

namespace stacks
{
    public interface Stack<T> : IEnumerable<T>
    {

        void push(T elem);

        T pop();

        bool full();

        bool empty();
    }
}
