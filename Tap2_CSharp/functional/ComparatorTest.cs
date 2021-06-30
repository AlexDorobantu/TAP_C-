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



            personList.Sort(delegate (Person x, Person y)
            {
                if (x.GetSurName == null && y.GetSurName == null) return 0;
                else if (x.GetSurName == null) return -1;
                else if (y.GetSurName == null) return 1;
                else return x.GetSurName.CompareTo(y.GetSurName);
            });

            foreach (Person p in personList)
            {
                p.PrintName();
            }


                       
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
