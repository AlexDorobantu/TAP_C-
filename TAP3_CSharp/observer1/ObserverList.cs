using System;
using System.Collections.Generic;
using System.Text;

namespace observer1
{
    public interface ObserverList<T> : IEnumerable<T>
    {

        void Register(Observer<T> observer);

        void Unregister(Observer<T> observer);

        void Add(T elem);

        void Remove(T elem);
    }
}
