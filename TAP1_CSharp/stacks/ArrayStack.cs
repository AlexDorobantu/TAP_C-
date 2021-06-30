using System;
using System.Collections.Generic;
using System.Text;

namespace stacks
{
    public class ArrayStack : IFormattable
    {

        private int[] pile;

        private int top;

        public ArrayStack(int size)
        {
            this.pile = new int[size];
            this.top = 0;
        }

        public void Push(int elem)
        {
            this.pile[this.top] = elem;
            this.top++;
        }

        public int Pop()
        {
            this.top--;
            return this.pile[this.top];
        }

        public bool Full()
        {
            return (this.top == this.pile.Length);
        }

        public bool Empty()
        {
            return (this.top == 0);
        }
    }
}
