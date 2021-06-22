using System;
using System.Collections.Generic;
using System.Text;

namespace proxy
{
    /**
 * http://www.tutorialspoint.com/design_pattern/proxy_pattern.htm
 */
    public class ProxyImage : Image
    {

        private RealImage realImage;

        private String fileName;

        public ProxyImage(String fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if ((this.realImage == null))
            {
                this.realImage = new RealImage(this.fileName);
            }

            this.realImage.Display();
        }
    }
}
