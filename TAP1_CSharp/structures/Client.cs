using System;
using System.Collections.Generic;
using System.Text;

namespace structures
{
    public class Client
    {

        private string name;

        private int age;

        public Client(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
