using System;
using System.Collections.Generic;

namespace visitor
{
    class Program
    {
        public static void Main(string[] args)
        {
            TaxiVisitor taxiDriver = new HonoredTaxiVisitor();
            
            LinkedList<Person> clients = new LinkedList<Person>();
            clients.AddLast(new HastyPerson(5));
            clients.AddLast(new LeisurelyPerson(8));
            
            foreach (Person client in clients)
            {
                client.Accept(taxiDriver);
            }

            Console.WriteLine("---");

            taxiDriver = new CorruptTaxiVisitor();
            foreach (Person client in clients)
            {
                client.Accept(taxiDriver);
            }
        }
    }
}
