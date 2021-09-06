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
    }
}