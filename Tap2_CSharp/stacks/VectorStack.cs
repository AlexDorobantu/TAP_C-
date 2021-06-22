using System;
using System.Collections.Generic;
using System.Text;

namespace stacks
{
    public class VectorStack<T> : Stack<T>
    {

        private Vector<T> monton;

        private int max;

        private int cnt;

        public VectorStack(int max)
        {
            this.monton = new Vector<T>();
            this.max = max;
            this.cnt = 0;
        }

        public void push(T elem)
        {
            this.monton.add(elem);
            this.cnt++;
        }

        public T pop()
        {
            T elem = this.monton.lastElement();
            this.monton.remove(elem);
            this.cnt = (this.cnt - 1);
            return elem;
        }

        public bool full()
        {
            return (this.max == this.cnt);
        }

        public bool empty()
        {
            return (this.cnt == 0);
        }

        public IEnumerable<T> iterator()
        {
            return this.monton.iterator();
        }
    }
}
