using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public class SearchVisitor : Visitor
    {

        private string name;

        private List<File> results;

        public SearchVisitor(String name)
        {
            this.results = new List<File>();
            this.name = name;
        }

        public override void Visit(File file)
        {
            if (file.GetName().Equals(this.name))
            {
                this.results.Add(file);
            }

        }

        public List<File> GetResults()
        {
            return this.results;
        }
    }
}
