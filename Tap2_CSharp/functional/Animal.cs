using System;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Animal
    {
        public override string ToString()
        {
            return ("Animal{" +
                "name='" + name + '\\' +
                ", age=" + age + '}');
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;

        private int age;

        public void Talk()
        {
            Console.WriteLine("hola");
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
