using System;
using System.Collections.Generic;

namespace filesystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Directory root = new Directory("root");
            Directory home = new Directory("home");
            Directory lp = new Directory("lp");
            File f1 = new File("f1", 1234);
            File f2 = new File("f2", 3445);
            File f3 = new File("f3", 6688);
            File f4 = new File("lp", 99999);
            root.AddChild(home);
            root.AddChild(f1);
            home.AddChild(lp);
            home.AddChild(f2);
            lp.AddChild(f3);
            root.AddChild(f4);


            root.Ls();
            Console.WriteLine("-------------");


            List<string> result = root.Collect();
            foreach (string elem in result)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("-------------");


            List<File> result2 = root.Search("lp");
            foreach (File elem2 in result2)
            {
                Console.WriteLine(elem2);
            }

            Console.WriteLine("-------------");


            Console.WriteLine(f3);


            Console.WriteLine("-------------");


            List<AComponent> result3 = root.ToList();
            foreach (AComponent a in result3)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("-------------");
            Console.WriteLine(("SIZE:" + root.Size()));
        }
    }
}
