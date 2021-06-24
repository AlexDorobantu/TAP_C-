using System;
using System.Collections.Generic;

namespace visitor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Directory root = new Directory("root");
            Directory home = new Directory("home");
            Directory lp = new Directory("lp");
            File f1 = new File("f1", 1234, "pedro");
            File f2 = new File("f2", 3445, "pep");
            File f3 = new File("f3", 6688, "pedro");
            File f4 = new File("lp", 99999, "jordi");
            root.AddChild(home);
            root.AddChild(f1);
            home.AddChild(lp);
            home.AddChild(f2);
            lp.AddChild(f3);
            root.AddChild(f4);


            root.Ls();
            Console.WriteLine("-------------");


            Console.WriteLine(f3);


            Console.WriteLine("-------------");
            List<AComponent> result3 = root.ToList();
            foreach (AComponent a in result3)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Visitor code:-----size");
            SizeVisitor vs = new SizeVisitor();
            root.Accept(vs);
            Console.WriteLine(("Size:" + vs.GetSize()));


            Console.WriteLine("Visitor code:-----search");
            SearchVisitor search = new SearchVisitor("f3");
            root.Accept(search);
            List<File> results = search.GetResults();
            foreach (File f in results)
            {
                Console.WriteLine(f);
            }


            Console.WriteLine("Visitor code:-----owner");
            OwnerVisitor owner = new OwnerVisitor("pedro");
            root.Accept(owner);
            List<File> results2 = owner.GetResults();
            foreach (File f in results2)
            {
                Console.WriteLine(f);
            }
        }
    }
}
