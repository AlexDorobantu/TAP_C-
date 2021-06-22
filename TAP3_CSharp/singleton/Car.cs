using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    public class Car
    {

        // The single instance
        private static Car car = new Car();

        private int fuelLevel = 0;

        // Private constructor makes impossible to create foreign instances
        private Car()
        {

        }

        // The only way to get the instance
        public static Car GetInstance()
        {
            return car;
        }

        public void FillUp()
        {
            this.fuelLevel = 4;
        }

        public void Run()
        {
            if (this.fuelLevel == 0)
            {
                Console.WriteLine("Fill up please");
            }
            else
            {
                this.fuelLevel--;
                Console.WriteLine("Ruuuuuun!!");
            }
        }
    }
}