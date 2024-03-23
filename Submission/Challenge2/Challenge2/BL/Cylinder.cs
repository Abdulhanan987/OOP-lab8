using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Cylinder : Circle
    {
        private double Heigth;
        public Cylinder()
        {

        }
        public Cylinder(double radius): base( radius)
        {
            
        }
        public Cylinder(double Heigth, double radius): base(radius)
        {
            this.Heigth = Heigth;
        }
        public Cylinder(double Heigth,double radius,string color):base(radius,color)
        {
            this.Heigth = Heigth;
        }
        public void SetHeigth(double Heigth)
        {
            this.Heigth = Heigth;
        }
        public double GetHeigth()
            {
            return this.Heigth;
        }
        public double GetVolume()
        {
            return 2 * Radius * 3.14*(Heigth + Radius);
        }
    }
}
