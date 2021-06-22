using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            CigaretteLighterReceptacle carLighter = new CigaretteLighterReceptacle();
            MP3Player myPlayer = new MP3Player("SanDisk", 4, new UsbToCarAdapter(carLighter));
            myPlayer.Charge();


        }
    }

}
