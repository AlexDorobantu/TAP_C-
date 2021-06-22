using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Cat : Animal
    {

        public Cat(int patas, int ojos) :
                base(patas, ojos)
        {
        }

        //  Herencia con reemplazo de metodo
        public string Talk()
        {
            return "Soy un Gato";
        }
    }
}
