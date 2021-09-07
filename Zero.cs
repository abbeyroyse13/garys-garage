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
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Silver and Red Zero glides {direction} on the wet road.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Silver and Red Zero's brakes screech at the stop sign.");
        }
    }
}