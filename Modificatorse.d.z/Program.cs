using System;

namespace Modificatorse.d.z
{
   
   
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            
            Console.WriteLine("Бренд: "+phone.GetBrand);
            Console.WriteLine("Уровень заряда: "+phone.GetBatteryLevel+"%");
            phone.TurnOn();
            phone.Charge(26);
            
        }
    }
}