using System;

namespace observer1
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestStrings();
            TestIntegers();
        }

        public static void TestStrings()
        {
            ObserverListImpl<string> strings = new ObserverListImpl<string>();
            try
            {
                strings.Register(new PrinterObserver<string>());
                strings.Register(new BackupObserver<string>());
            }
            catch (RepeatedObserverException e)
            {
                Console.WriteLine("Existent Observer Exception....");
                //Console.WriteLine(("   \'---> " + e.GetMessage()));
            }

            foreach (String s in new String[] {"hola", "adios", "hello", "goodbye"})
            {
                strings.Add(s);
            }

            Console.WriteLine("List content:");
            foreach (String s in strings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            try
            {
                strings.Register(new BackupObserver<string>());
            }
            catch (RepeatedObserverException e)
            {
                Console.WriteLine("CExistent Observer...");
                //Console.WriteLine(("   \'---> " + e.GetMessage()));
            }

        }

        public static void TestIntegers()
        {
            ObserverListImpl<int> integers = new ObserverListImpl<int>();
            try
            {
                integers.Register(new PrinterObserver<int>());
                integers.Register(new BackupObserver<int>());
            }
            catch (RepeatedObserverException e)
            {
                Console.WriteLine("Existent Observer.");
                //Console.WriteLine(("   \'---> " + e.getMessage()));
            }

            foreach (int s in new int[] {4, 6, 3, 5, 4})
            {
                integers.Add(s);
            }

            Console.WriteLine("List content:");
            foreach (int s in integers)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }
    }
}
