using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public interface Strategy
    {
        int DoOperation(int num1, int num2);
    }
}
