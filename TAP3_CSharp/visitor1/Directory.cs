using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public class Directory : AComponent
    {

        private string name;

        private List<AComponent> children;

        private AComponent parent = null;

        public Directory(string name)
        {
            this.name = name;
            this.children = new List<AComponent>();
        }

        public void AddChild(AComponent child)
        {
            this.children.Add(child);
            child.SetParent(this);
        }

        public void RemoveChild(AComponent child)
        {
            this.children.Remove(child);
        }

        public void Ls()
        {
            Console.WriteLine(this.name);
            foreach (AComponent child in this.children)
            {
                child.Ls();
            }

        }

        public void SetParent(AComponent parent)
        {
            this.parent = parent;
        }

        public override string ToString()
        {
            string path = "/";
            if ((this.parent != null))
            {
                path = (this.parent.ToString() + "/");
            }
            return (path + this.name);
        }

        public List<AComponent> ToList()
        {
            List<AComponent> result = new List<AComponent>();
            result.Add(this);
            foreach (AComponent child in this.children)
            {
                result.AddRange(child.ToList());
            }
            return result;
        }

        public List<AComponent> GetChildren()
        {
            return this.children;
        }

        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
