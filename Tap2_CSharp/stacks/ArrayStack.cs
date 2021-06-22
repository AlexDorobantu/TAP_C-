using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace stacks
{
    public class ArrayStack<T> : Stack<T>, IEnumerable<T>
    {

        private T[] monton;

        private int cima;

        int cnt = 0;

        public ArrayStack(T[] lista)
        {
            this.monton = lista;
            this.cima = 0;
        }

        public void Push(T elem)
        {
            this.monton[this.cima] = elem;
            this.cima++;
        }

        public T Pop()
        {
            this.cima--;
            return this.monton[this.cima];
        }

        public bool Full()
        {
            return (this.cima == this.monton.Length);
        }

        public bool Empty()
        {
            return (this.cima == 0);
        }

        public IEnumerable<T> Iterator()
        {
            return this;
        }

        public bool HasNext()
        {
            return (this.cnt < this.cima);
        }

        public T Next()
        {
            Console.WriteLine("avanza");
            this.cnt = (this.cnt + 1);
            return this.monton[(this.cnt - 1)];
        }

        public void Remove()
        {
            //  TODO Auto-generated method stub
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
