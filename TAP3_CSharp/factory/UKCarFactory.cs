using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class UKCarFactory : AbstractCarFactory
    {
        public AbstractCar CreateCar()
        {
            return new UKCar();
        }
    }
}
