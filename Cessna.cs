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
    }
}