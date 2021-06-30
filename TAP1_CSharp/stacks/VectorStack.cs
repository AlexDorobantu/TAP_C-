using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.IO;
using System.Collections;

namespace stacks
{
    public class VectorStack : Stack
    {

        private var pile;

        private int size;

        private int cnt;

        public VectorStack(int size)
        {
            this.pile = new Vector<int>(size);
            this.size = size;
            this.cnt = 0;
        }

        public  void Push(int elem)
        {
            this.pile.Add(elem);
            this.cnt++;
        }

        public int Pop()
        {
            int elem = this.pile.lastElement();
            this.pile.Remove(elem);
            this.cnt = (this.cnt - 1);
            return elem;
        }

        public bool Full()
        {
            return (this.size == this.cnt);
        }

        public bool Empty()
        {
            return (this.cnt == 0);
        }
    }
}
