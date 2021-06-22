using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace functional
{
    public class Person
    {
        private string givenName;
        private string surName;
        private int age;
        private Gender gender;
        private string eMail;
        private string phone;
        private string address;

        public Person(string givenName, string surName, int age, Gender gender, string eMail, string phone, string address)
        {
            this.givenName = givenName;
            this.surName = surName;
            this.age = age;
            this.gender = gender;
            this.eMail = eMail;
            this.phone = phone;
            this.address = address;
        }


        public static ArrayList CreateShortList()
        {
            var people = new ArrayList
            {
                new Person("Bob", "Baker", 2, Gender.MALE, "bob.baker@example.com", "201-121-4678", "44 4th St, Smallville, KS 12333"),
                new Person("Jane", "Doe", 25, Gender.FEMALE, "jane.doe@example.com", "202-123-4678", "33 3rd St, Smallville, KS 12333"),
                new Person("John", "Doe", 25, Gender.MALE, "john.doe@example.com", "202-123-4678", "33 3rd St, Smallville, KS 12333"),
                new Person("James", "Johnson", 45, Gender.MALE, "james.johnson@example.com", "333-456-1233", "201 2nd St, New York, NY 12111"),
                new Person("Joe", "Bailey", 67, Gender.FEMALE, "joebob.bailey@example.com", "112-111-1111", "111 1st St, Town, CA 11111"),
                new Person("Phil", "Smith", 55, Gender.MALE, "phil.smith@example.com", "222-33-1234", "22 2nd St, New Park, CO 222333")
            };
            return people;
        }


        public override string ToString()
        {
            return ("Person{" + "givenName='" + this.givenName + '\\' +
                   ", age=" + this.age +
                   ", gender=" + this.gender +
                   '}');
        }

        public Gender GetGender()
        {
            return this.gender;
        }

        public string GetSurName()
        {
            return this.surName;
        }

        public void PrintName()
        {
            Console.WriteLine(("Name: "
                            + (this.givenName + (" " + this.surName))));
        }

        public int GetAge()
        {
            return this.age;
        }


    }
}
