using System;

namespace Modificatorse.d.z
{
   
   
    class Program
    {
        static void Main(string[] args)
        {
           ElectronicDevice electronicDevice = new ElectronicDevice("Electronic Device",34,false);
           Phone phone = new Phone();
           Console.WriteLine(phone.GetBrand);
           Console.WriteLine(phone.GetBatteryLevel);
           phone.TurnOn();
           phone.Charge(65);



        }
    }
}