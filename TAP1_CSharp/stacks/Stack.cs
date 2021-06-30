using System;
using System.Collections.Generic;
using System.Text;

namespace stacks
{
    public interface IFormattable
    {
        //Introduce an element at the top
        void Push(int elem);

        //Obtain element that's on the top and delete it
        int Pop();

        //Say if stack is full.
        bool Full();

        //Say if stack is empty.
        bool Empty();
    }
}
