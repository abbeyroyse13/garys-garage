using System;

namespace Garage 
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }
        public override void Drive()
        {
            Console.WriteLine("The Silver and Red Zero goes by. Shooooommm!");
        }
    }
}