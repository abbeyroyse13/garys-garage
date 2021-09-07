using System;

namespace Garage 
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {

        }
        public override void Drive()
        {
            Console.WriteLine("The Navy Blue Cessna goes by. Zoooooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Navy Blue Cessna comes to a stop on the runway.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Navy Blue Cessna turns {direction} on the runway.");
        }
    }
}