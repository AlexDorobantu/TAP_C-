using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class OperationAdd : Strategy
    {

        public int DoOperation(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
}
