using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class SpanishCarFactory : AbstractCarFactory
    {

        public AbstractCar CreateCar()
        {
            return new SpanishCar();
        }
    }
}
