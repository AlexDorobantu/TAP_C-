using System;

namespace factory
{
    class Program
    {

        public static void Main(String[] args)
        {
            AbstractCarFactory factory = new SpanishCarFactory();
            //  the client can work with the factory in an unique way, regardless of
            //  its specific type. He also can create a car and use it without knowing
            //  details of its creation and its specific type
            AbstractCar car = factory.CreateCar();
            Console.WriteLine(car.GetDriverSide());
        }
    }
}
