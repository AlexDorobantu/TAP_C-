using System;

namespace singleton
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Impossible to create instances using "new"
            //Car myCar=new Car();

            Car myCar = Car.GetInstance();
            myCar.Run();
            myCar.FillUp();
            myCar.Run();

            //myCar2 = myCar --> both are the same instance, according to Singleton
            Car myCar2 = Car.GetInstance();
            myCar2.Run();

        }
    }
}
