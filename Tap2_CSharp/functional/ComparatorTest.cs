using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class ComparatorTest
    {

        public static void Main(String[] args)
        {
            var personList = Person.CreateShortList();

            //  Sort with Inner Class
            personList.Sort();
            Console.WriteLine("=== Sorted Asc SurName ===");
            foreach (Person p in personList)
            {
                p.PrintName();
            }

            //  Use Lambda instead
            //  Print Asc
            Console.WriteLine("=== Sorted Asc SurName ===");
            personList.Sort(personList, Person);
            p1.getSurName().compareTo(p2.getSurName());
            foreach (Person p in personList)
            {
                p.PrintName();
            }

            //  Print Desc
            Console.WriteLine("=== Sorted Desc SurName ===");
            p2.getSurName().compareTo(p1.getSurName());
            foreach (Person p in personList)
            {
                p.PrintName();
            }

        }
    }
}
