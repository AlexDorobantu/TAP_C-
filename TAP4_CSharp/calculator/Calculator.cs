﻿using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    /**
 * Simple calculator class to be tested
 *
 */
    public class Calculator
    {

        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
