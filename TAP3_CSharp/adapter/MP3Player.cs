using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    public class MP3Player
    {

        private string brand;

        private int storageCapacity;

        private int batteryLevel = 0;

        private Usb batteryChargerInterface;

        public MP3Player(String brand, int storageCapacity, Usb batteryCharger)
        {
            this.brand = brand;
            this.storageCapacity = storageCapacity;
            this.batteryChargerInterface = batteryCharger;
        }

        public void Charge()
        {
            Console.WriteLine(("--- Battery level before: " + (this.batteryLevel + " ---")));

            this.batteryLevel = (this.batteryLevel + this.batteryChargerInterface.GetPower());

            Console.WriteLine(("--- Battery level after: " + (this.batteryLevel + " ---")));
        }

        public String GetBrand()
        {
            return this.brand;
        }

        public int GetStorageCapacity()
        {
            return this.storageCapacity;
        }
    }
}
