using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Animal
    {

        protected int legs;
        private int eyes;

        public Animal(int legs, int ojos)
        {
            this.legs = legs;
            this.eyes = ojos;
        }

        public T GetThing<T>(T bicho)
        {
            return bicho;
        }

        public int GetLegs()
        {
            return this.legs;
        }

        public void SetLegs(int legs)
        {
            this.legs = legs;
        }

        public int GetEyes()
        {
            return this.eyes;
        }

        public void SetEyes(int eyes)
        {
            this.eyes = eyes;
        }

        public string Talk()
        {
            return "Soy un animal";
        }
    }
}
