using System;

namespace cars
{
    class UseCar
    {
        static void Main(string[] args)
        {

            // Create cars
            Car myCar = new Car("bmw", 100);
            Car otherCar = new Car("seat", 10);
            Car copy = new Car("seat", 10);

            // Compare memory addresses
            if (otherCar == copy)
                Console.WriteLine("equals  == otherCar and copy");

            // Use method equals in Car class
            if (otherCar.Equals(copy))
                Console.WriteLine("equals otherCar and copy");

            if (myCar.Equals(otherCar))
                Console.WriteLine("equals myCar and otherCar");
            Console.WriteLine("My car: " + myCar.ToString());

            Car peugeot = new Car("peugeot", 900);
            Car renault;
            
            renault = peugeot;

            peugeot.Brand = "mercedes";
            Console.WriteLine("Renault " + renault.ToString());
            Console.WriteLine("Peugeot " + peugeot.ToString());

            Car audi = new Car("audi", 900);
            renault = audi.clone();
            renault.Brand = "ferrari";

            Console.WriteLine("Renault " + renault.ToString());
            Console.WriteLine("Audi " + audi.ToString());


        }
    }
}
