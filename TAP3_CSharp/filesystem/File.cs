using System;
using System.Collections.Generic;
using System.Text;

namespace filesystem
{
    public class File : AComponent
    {

        private string name;

        private int size;
        private AComponent parent;

        public File(string name)
        {
            this.name = name;
        }

        public void Ls()
        {
            Console.WriteLine(this.name);
        }

        public List<string> Collect()
        {
            List<string> result = new List<string>();
            result.Add(this.name);
            return result;
        }

        public List<File> Search(string name)
        {
            List<File> result = new List<File>();
            if (this.name.Equals(name))
            {
                result.Add(this);
            }
            return result;
        }

        public void SetParent(AComponent parent)
        {
            this.parent = parent;
        }

        public String ToString()
        {
            string path = (this.parent.ToString() + "/");
            return (path + this.name);
        }

        public String GetName()
        {
            return this.name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public List<AComponent> ToList()
        {
            List<AComponent> result = new List<AComponent>();
            result.Add(this);
            return result;
        }

        public File(String name, int size) :
                base()
        {
            this.name = name;
            this.size = size;
        }

        public int GetSize()
        {
            return this.size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }

        public int Size()
        {
            return this.size;
        }
    }
}
