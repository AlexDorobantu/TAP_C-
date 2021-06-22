using System;
using System.Collections.Generic;
using System.Text;

namespace decorator
{
    public class SpoilerDecorator : Car
    {

        private Car client;

        public SpoilerDecorator(Car car) : base("", 0)
        {
            this.client = car;
        }

        public string Description => (this.client.GetDescription() + " with a spoiler");

        public float Price => (this.client.Price + 200);
    }
}
