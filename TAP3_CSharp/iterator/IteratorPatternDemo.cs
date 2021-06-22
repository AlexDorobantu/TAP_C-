using System;

namespace iterator
{
    class IteratorPatternDemo
    {
        public static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();
            for (Iterator iter = namesRepository.GetIterator(); iter.HasNext();
            )
            {
                string name = ((string)(iter.Next()));
                Console.WriteLine(("Name : " + name));
            }

        }
    }
}
