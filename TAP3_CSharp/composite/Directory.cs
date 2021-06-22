using System;
using System.Collections.Generic;
using System.Text;

namespace composite
{
    public class Directory : AComponent
    {

        private string name;

        private List<AComponent> children;

        public Directory(string name)
        {
            this.name = name;
            this.children = new List<AComponent>();
        }

        public void AddChild(AComponent child)
        {
            this.children.Add(child);
        }

        public void RemoveChild(AComponent child)
        {
            this.children.Remove(child);
        }

        public int GetSize()
        {
            int result = 0;
            foreach (AComponent child in children)
            {
                result = (result + child.GetSize());
            }

            return result;
        }
    }
}
