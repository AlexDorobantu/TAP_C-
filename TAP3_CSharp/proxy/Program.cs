using System;

namespace proxy
{
    class Program
    {
        /**
         * http://www.tutorialspoint.com/design_pattern/proxy_pattern.htm
         */
        static void Main(string[] args)
        {
            Image image = new ProxyImage("test_10mb.jpg");
            // image will be loaded from disk
            image.Display();
            Console.WriteLine("");

            // image will not be loaded from disk
            image.Display();
        }
    }
}
