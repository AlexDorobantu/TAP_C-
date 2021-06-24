using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace observer1
{
    public class BackupObserver<T> : Observer<T>
    {

        private Vector<T> backup;

        public BackupObserver()
        {
            this.backup = new Vector<T>();
        }

        public void NotifyAdd(T elem)
        {
            this.backup.Add(elem);
        }

        public void NotifyRemove(T elem)
        {
            this.backup.Remove(elem);
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
