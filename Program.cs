using System;
using System.Collections.Generic;

namespace Garage
{
    class GarysGarage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gary's Garage");
            Console.WriteLine("-------------");

            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}