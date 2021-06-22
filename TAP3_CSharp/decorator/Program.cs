using System;

namespace decorator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car("Chevrolet", 10000);
            Car decorator = new SpoilerDecorator(myCar);
            Car decorator2 = new NitroDecorator(decorator);
            // Let's decorate
            //     myCar=new NitroDecorator(myCar);
            //     myCar=new SpoilerDecorator(myCar);
            // Car myCar = new SpoilerDecorator(new NitroDecorator(new Car("Chevrolet",10000)));

            Console.WriteLine(("Description: " + myCar.GetDescription()));
            Console.WriteLine(("Price: " + (myCar.Price + "€")));
        }
    }
}