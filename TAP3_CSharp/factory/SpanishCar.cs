using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    public class SpanishCar : AbstractCar
    {
        public string GetDriverSide()
        {
            return "left";
        }
    }
}
