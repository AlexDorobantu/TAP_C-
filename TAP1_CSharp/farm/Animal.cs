using System;

namespace farm
{
    public class Animal
    {
        //  Legs is protected so all child can work directly with this attribute
        protected int legs;
        private int eyes;

        public Animal(int legs, int eyes)
        {
            this.legs = legs;
            this.eyes = eyes;
        }


        public void setLegs(int legs)
        {
            this.legs = legs;
        }

        public int getLegs()
        {
            return legs;
        }

        public void setEyes(int ojos)
        {
            this.eyes = ojos;
        }

        public int getEyes()
        {
            return eyes;
        }

        //public int eyes { get => eyes; set => eyes = value; }
        //protected int Legs { get => legs; set => legs = value; }

        public String Talk => "I am an animal";
    }
}
