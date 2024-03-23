using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bMW = new BMW(50,"Black","Variant",20000);
            Console.WriteLine(bMW.FuelCalculation());
            Console.WriteLine(bMW.getPrice());
            Console.WriteLine(bMW.getModel());
            Audi audi = new Audi(80,"Blue","2080",1200000);
            Console.WriteLine(audi.getPrice());
            Console.WriteLine(audi.getModel());
            Console.WriteLine(audi.FuelCalculation());
           audi.setLigthOn();
            if(audi.getLigthState())
            Console.WriteLine("Ligths On");
            GLI gLI = new GLI(60, "Brown", "2070", 13000, "Heavy");
            Console.WriteLine(gLI.getPrice());
            Console.WriteLine(gLI.getModel());
            Console.WriteLine(gLI.FuelCalculation());
            Console.WriteLine(gLI.getDescription());
            Console.ReadKey();

        }
    }
}
