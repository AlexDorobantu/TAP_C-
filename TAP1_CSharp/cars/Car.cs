using System;
using System.Collections.Generic;
using System.Text;

namespace cars
{
    class Car
    {
        private String brand;
        private int price;



        public Car(String brand, int price)
        {
            this.brand = brand;
            this.price = price;
        }

        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }

        //Ctrl+R and Ctrl+E to generate getters and setters

        // Method to determine if two cars are equals
        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   brand == car.brand &&
                   price == car.price;
        }

        //  Method to create another car with the same characteristics
        public Car clone()
        {
            return new Car(brand, price);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "(" + brand + "," + Price + ")";
        }
    }

}
