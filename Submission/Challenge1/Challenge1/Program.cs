using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike mountainBike = new MountainBike(1,1,2,3);
            mountainBike.setHeigth(4);
            mountainBike.applyBrake(2);
            mountainBike.setSpeed(3);
            Console.WriteLine(mountainBike.getSpeed());
            Console.WriteLine(mountainBike.getHeigth());
            Console.WriteLine(mountainBike.getCadence());
            Console.WriteLine(mountainBike.getGear());
            Console.ReadKey();
        }
    }
}
