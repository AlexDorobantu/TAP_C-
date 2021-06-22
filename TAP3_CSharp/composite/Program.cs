using System;

namespace composite
{
    class Program
    {
        public static void Main(String[] args)
        {
            Directory root = new Directory("root");
            Directory home = new Directory("home");
            Directory tap = new Directory("tap");
            File f1 = new File("f1", 1234);
            File f2 = new File("f2", 3445);
            File f3 = new File("f3", 6688);
            File f4 = new File("lp", 99999);
            root.AddChild(home);
            root.AddChild(f1);
            home.AddChild(tap);
            home.AddChild(f2);
            tap.AddChild(f3);
            root.AddChild(f4);

            Console.WriteLine("-------------");
            Console.WriteLine(("Root SIZE:" + root.GetSize()));
            Console.WriteLine(("Home SIZE:" + home.GetSize()));
            Console.WriteLine(("TAP SIZE:" + tap.GetSize()));
        }
    }
}
