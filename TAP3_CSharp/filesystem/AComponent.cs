using System;
using System.Collections.Generic;
using System.Text;

namespace filesystem
{
    public interface AComponent
    {
        public void Ls();
        public List<string> Collect();
        public List<AComponent> ToList();
        public List<File> Search(string name);
        public int Size();
        public void SetParent(AComponent parent);
    }
}
