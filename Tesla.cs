using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("The Aquamarine Tesla goes by. Brooooommm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Aquamarine Tesla turns {direction} in the parking lot.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Aquamarine Tesla comes to a halt in front of the old folks home.");
        }
    }
}