using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    public class Thing2<T : Animal>
    {

        private T name;

        public Thing2(T name)
        {
            this.name = name;
        }

        public T GetName()
        {
            return this.name;
        }

        public void SetName(T name)
        {
            this.name = name;
        }
    }
}
