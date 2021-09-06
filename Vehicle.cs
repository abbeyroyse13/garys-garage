using System;

namespace Garage 
{
    public class Vehicle 
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public Turn(string direction) { get; set; }
        public string Stop { get; set; }

        public virtual void Drive()
        {
            // Console.WriteLine("Vrooom!");
        }
        public virtual void Stop()
        {
            
        }
    }
}