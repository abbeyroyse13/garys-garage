using System;

namespace Garage 
{
    public class Vehicle 
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stops here!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Turning! {direction}");
        }
    }
}