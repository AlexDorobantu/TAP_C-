using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public class NameRepository : Container
    {
        public static List<string> names = new List<string>() { "Robert", "John", "Julie", "Lora" };

        public Iterator GetIterator()
        {
            return new NameIterator();
        }






        public class NameIterator : Iterator
        {

            int index;


            public bool HasNext()
            {
                if ((this.index < names.Count))
                {
                    return true;
                }

                return false;
            }


            public Object Next()
            {
                if (this.HasNext())
                {
                    return names[index++];
                }

                return null;
            }
        }

    }
}
