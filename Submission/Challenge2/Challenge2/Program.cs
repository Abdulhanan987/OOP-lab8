using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(2,3,"Orange");
            Console.WriteLine(cylinder.getString());
            Console.WriteLine(cylinder.getArea());
            Console.WriteLine(cylinder.GetVolume());
            Console.WriteLine(cylinder.GetHeigth());
            Console.WriteLine(cylinder.getRadius());
            Console.WriteLine(cylinder.getColor());
            Console.ReadKey();
        }
    }
}
