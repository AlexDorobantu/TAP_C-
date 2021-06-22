using System;
using System.Collections.Generic;
using System.Text;

namespace farm
{
    public class Dog : Animal
    {

        private bool fleas { get; set; }  //  Own attribute

        public Dog(int legs, int eyes, bool fleas) : base(legs, eyes)
        {
            this.fleas = fleas;
        }

        public void setFleas(bool fleas)
        {
            this.fleas = fleas;
        }

        public bool getFleas()
        {
            return fleas;
        }


        //  change attributes
        public void changeFather()
        {
            this.legs = 3;
            //this.eyes = 2;
            setLegs(4);
            setEyes(5);
        }

        //  Overwrite father's method
        public String Talk => ("Fleas " + this.fleas);
    }
}
