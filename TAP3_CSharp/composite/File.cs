using System;
using System.Collections.Generic;
using System.Text;

namespace composite
{
    public class File : AComponent
    {

        private string name;

        private int size;

        public File(String name, int size) : base()
        {
            this.name = name;
            this.size = size;
        }

        public String GetName()
        {
            return this.name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public int GetSize()
        {
            return this.size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

        public int Size => this.size;

    }
}
