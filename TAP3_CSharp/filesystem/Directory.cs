using System;
using System.Collections.Generic;
using System.Text;

namespace filesystem
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

        public List<string> Collect()
        {
            List<string> result = new List<string>();
            result.Add(this.name);
            foreach (AComponent child in this.children)
            {
                result.AddRange(child.Collect());
            }

            return result;
        }

        public List<File> Search(string name)
        {
            List<File> result = new List<File>();
            foreach (AComponent child in this.children)
            {
                result.AddRange(child.Search("lp"));
            }
            return result;
        }

        public void SetParent(AComponent parent)
        {
            this.parent = parent;
        }

        public string ToString()
        {
            string path = "/";
            if (this.parent != null)
            {
                path = this.parent.ToString() + "/";
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

        public int Size()
        {
            int result = 0;
            foreach (AComponent child in this.children)
            {
                result = (result + child.Size());
            }
            return result;
        }
    }
}
