using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    public class UKCar : AbstractCar
    {
        public string GetDriverSide()
        {
            return "right";
        }
    }
}
