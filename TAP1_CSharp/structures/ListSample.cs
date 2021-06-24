using System;
using System.Collections.Generic;
using System.Text;

namespace structures
{
    public class ListSample
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("111", "pedro", 1);
            Person p2 = new Person("222", "pep", 2);
            Person p3 = new Person("333", "pere", 3);
            
            List<Person> persons = new List<Person>();

            //  What happens if Persons is not set in List ? Can we add a String to the List ? Where is the error ?
            // List persons = new LinkedList();
           
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

        }
    }
}
