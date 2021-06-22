using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public class Customer
    {
        private string id;
        private string name;
        private string address;
        private string phoneNumber;

        public Customer(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "Customer{" + 
                    "name='" + name + '\'' +
                    ", id='" + id + '\'' +
                    '}';
        }
    }
}
