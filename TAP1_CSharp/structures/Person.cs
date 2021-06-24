using System;
using System.Collections.Generic;
using System.Text;

namespace structures
{
    public class Person
    {

        string dni;

        string name;

        int age;


        public override string ToString()
        {
            return ("Person{" + 
                "dni='" + this.dni + '\\' +
                ", name='" + this.name + '\\'+
                '}');
        }

        public string GetDni()
        {
            return this.dni;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public Person(string dni, string name, int age)
        {
            this.dni = dni;
            this.name = name;
            this.age = age;
        }
    }

}
