using System;
using System.Collections.Generic;
using System.Text;

namespace visitor1
{
    public class OwnerVisitor : Visitor
    {

        private string owner;

        private List<File> results;

        public OwnerVisitor(string owner)
        {
            this.results = new List<File>();
            this.owner = owner;
        }

        public override void Visit(File file)
        {
            if (file.GetOwner().Equals(this.owner))
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
