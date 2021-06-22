using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class RunnableTest
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("=== RunnableTest ===");
            //  Anonymous Runnable
            Runnable r1 = new Runnable();
            //  Lambda Runnable
            Runnable r2;
            Console.WriteLine("Hello world two!");
            //  Run em!
            r1.run();
            r2.run();
        }
    }
}
