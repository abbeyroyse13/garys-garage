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
            Ram trx = new Ram();

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine(" ");
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine(" ");
            mx410.Drive();
            mx410.Stop();
            mx410.Turn("right");
            Console.WriteLine(" ");
            trx.Drive();
            trx.Turn("left");
            trx.Stop();

        }
    }
}