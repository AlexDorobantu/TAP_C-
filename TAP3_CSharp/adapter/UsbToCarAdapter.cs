using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    public class UsbToCarAdapter : Usb
    {

        private CigaretteLighterReceptacle carInterface;

        public UsbToCarAdapter(CigaretteLighterReceptacle carInterface)
        {
            this.carInterface = carInterface;
        }

        public int GetPower()
        {
            return this.carInterface.GetEnergy();
        }
    }
}
