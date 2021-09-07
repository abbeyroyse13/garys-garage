using System;

namespace Garage 
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {

        }
        public override void Drive()
        {
            Console.WriteLine("The Hot Pink Ram goes by. Vroooomm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Hot Pink Ram turns {direction} on the street.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Hot Pink Ram stops at the red light.");
        }
    }
}