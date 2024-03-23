using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Circle
    {
        protected double Radius;
        protected string Color;
        public Circle()
        {

        }
        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void setColor(string color)
        {
            this.Color = color;
        }
        public string getColor()
        {
            return this.Color;
        }
        public void setRadius(double radius)
        {
            this.Radius = radius;
        }
        public double getRadius()
        {
            return this.Radius;
        }
        public double getArea()
        {
            return 2* this.Radius*3.14;
        }
        public string getString()
        {
            return "Circle[radius="+Radius+",color="+Color+"]";
        }
    }
}
