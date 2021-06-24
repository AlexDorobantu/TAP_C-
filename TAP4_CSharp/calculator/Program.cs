using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double value1 = 3;
            double value2 = 3;
            
            double result = calc.Add(value1, value2);
            Console.WriteLine(value2+" + "+ value2+" = "+result);


            value1 = 9;
            result = calc.Subtract(value1, value2);
            Console.WriteLine(value2 + " - " + value2 + " = " + result);

            result = calc.Multiply(value1, value2);
            Console.WriteLine(value2 + " * " + value2 + " = " + result);

            result = calc.Divide(value1, value2);
            Console.WriteLine(value2 + " / " + value2 + " = " + result);
        }
    }
}
