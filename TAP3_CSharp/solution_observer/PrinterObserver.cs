using System;
using System.Collections.Generic;
using System.Text;

namespace observer1
{
    public class PrinterObserver<T> : Observer<T>
    {

        public void NotifyAdd(T elem)
        {
            Console.WriteLine("ADDED: " + elem);
        }

        public void NotifyRemove(T elem)
        {
            Console.WriteLine("REMOVED: " + elem);
        }

        public bool Equals(Object obj)
        {
            return this.GetClass().GetCanonicalName().Equals(obj.GetClass().GetCanonicalName());
        }

        public String ToString()
        {
            return this.GetClass().GetName();
        }
    }
}
