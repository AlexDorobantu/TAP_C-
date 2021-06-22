using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public class NitroDecorator : Car
    {

        private Car client;

        public NitroDecorator(Car car) :
                base("", 0)
        {
            this.client = car;
        }

        public string Description => (this.client.GetDescription() + " with nitrous oxide system");

        public float Price => (this.client.Price + 7000);
    }
}
