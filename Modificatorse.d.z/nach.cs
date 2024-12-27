using System;
namespace Modificatorse.d.z
{
    class ElectronicDevice
    {
        private string Brand ;
        protected int BatteryLevel; 
        private bool IsOn ;

        
       
        

        public string GetBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public int GetBatteryLevel
        {
            get { return BatteryLevel; }
            set { BatteryLevel = value; }
        }

        public bool GetIsOn
        {
            get { return IsOn; }
            set { IsOn = value; }
        }
        public ElectronicDevice(string Brand, int BatteryLevel, bool IsOn)
        {
            this.Brand = Brand;
            this.BatteryLevel = BatteryLevel;
            this.IsOn = IsOn;
        
        }

        


        public void TurnOn()
        {
            
            Console.WriteLine(Brand + " Is Turned On");
        }

        public void TurnOff()
        {
         
            Console.WriteLine(Brand + " Is Turned Off");
        }

        public void Charge(int amount)
        {
            GetBatteryLevel += amount;
            if (GetBatteryLevel >= 100)
            {
                GetBatteryLevel = 100;

            }

            Console.WriteLine("Устройство заряжен до " + GetBatteryLevel + "%");
        }
    }
}

