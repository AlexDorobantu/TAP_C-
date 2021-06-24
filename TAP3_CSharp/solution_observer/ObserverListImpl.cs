using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Collections;

namespace observer1
{
    public class ObserverListImpl<T> : ObserverList<T>
    {

        Vector<Observer<T>> observers;

        Vector<T> content;

        public ObserverListImpl()
        {
            observers = new Vector<Observer<T>>();
            content = new Vector<T>();
        }


        public void Register(Observer<T> observer)
        {
            if (observers.Contains(observer))
            {
                throw new RepeatedObserverException(("Observer \'"
                                + (observer + "\' already exists!")));
            }

            observers.Add(observer);
        }

        public void Unregister(Observer<T> observer)
        {
            observers.Remove(observer);
        }

        public void Add(T elem)
        {
            content.Add(elem);
            NotifyAllAdd(elem);
        }

        public void Remove(T elem)
        {
            content.Remove(elem);
            notifyAllRemove(elem);
        }

        protected void NotifyAllAdd(T elem)
        {
            foreach (Observer<T> ob in observers)
            {
                ob.NotifyAdd(elem);
            }

        }

        protected void notifyAllRemove(T elem)
        {
            foreach (Observer<T> ob in observers)
            {
                ob.NotifyRemove(elem);
            }

        }

        public Iterator<T> iterator()
        {
            return content.iterator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
