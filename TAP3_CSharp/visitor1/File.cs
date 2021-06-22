using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public class File : AComponent
    {

        private string name;

        private int size;

        private string owner;

        public File(string name, int size, string owner)
        {
            this.name = name;
            this.size = size;
            this.owner = owner;
        }

        public string GetOwner()
        {
            return this.owner;
        }

        public int GetSize()
        {
            return this.size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

        private AComponent parent;

        public void Ls()
        {
            Console.WriteLine(this.name);
        }

        public void SetParent(AComponent parent)
        {
            this.parent = parent;
        }

        public override string ToString()
        {
            string path = (this.parent.ToString() + "/");
            return (path + this.name);
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public List<AComponent> ToList()
        {
            List<AComponent> result = new List<AComponent>();
            result.Add(this);
            return result;
        }

        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
