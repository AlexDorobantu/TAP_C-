using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public class Context
    {

        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return this.strategy.DoOperation(num1, num2);
        }
    }
}
