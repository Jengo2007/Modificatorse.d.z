using System;
namespace Modificatorse.d.z
{
    class Phone : ElectronicDevice
    {
        public Phone()
        {
            GetBrand = "IPhone";
            GetBatteryLevel =86;
            GetIsOn = GetIsOn;

        }

        public Phone(string Brand, int BatteryLevel, bool IsOn)
        {
            GetBrand = Brand;
            GetBatteryLevel = BatteryLevel;
            GetIsOn = GetIsOn;
        }
        
    }
}