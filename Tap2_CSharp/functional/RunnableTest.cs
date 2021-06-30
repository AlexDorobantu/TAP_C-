using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace functional
{
    public class RunnableTest
    {

        public void Run()
        {
            Console.WriteLine("Running in a different thread.");
         }

        public static void Main(String[] args)
        {
            Console.WriteLine("=== RunnableTest ===");
            //  Anonymous Runnable
            RunnableTest r1 = new RunnableTest();

            Thread newThread = new Thread(new ThreadStart(r1.Run));
            newThread.Start();

            //  Lambda Runnable
            RunnableTest r2 = new RunnableTest();
        
      
            Thread newThread1 = new Thread(new ThreadStart(r2.Run));
            newThread1.Start();


        }
    }
}
