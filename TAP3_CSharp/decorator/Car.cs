using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    //An instance of this class will be decorated
    public class Car
    {

        private string description;

        private float price;

        public Car(string description, float price)
        {
            this.description = description;
            this.price = price;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public float Price => this.price;
    }
}
