using System;
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    public class RealImage : Image
    {

        private string fileName;

        public RealImage(String fileName)
        {
            this.fileName = fileName;
            this.LoadFromDisk(this.fileName);
        }

        public void Display()
        {
            Console.WriteLine(("Displaying " + this.fileName));
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine(("Loading " + this.fileName));
        }
    }
}
