using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Thing<T>
    {

        private T name;

        public Thing(T name)
        {
            this.name = name;
        }

        public T GetName()
        {
            return this.name;
        }

        public void SetName(T nombre)
        {
            this.name = nombre;
        }
    }
}
