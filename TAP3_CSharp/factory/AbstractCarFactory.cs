using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    //An interface is chosen instead an abstract class
    //because in this example aren't needed attributes and methods already implemented
    public interface AbstractCarFactory
    {
        AbstractCar CreateCar();
    }
}
