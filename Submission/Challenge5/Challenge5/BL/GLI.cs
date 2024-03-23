using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class GLI : Car
    {
        private int TopSpeed;
        private string Description;
        public GLI(int speed,string color, string model, float price, string description) : base(color, model, price)
        {
            TopSpeed = speed;
            Description = description;
        }
        public float FuelCalculation()
        {
            float var;
            var = TopSpeed / 30;
            return var;

        }
        public void setSpeed(int speed)
        {
            TopSpeed = speed;
        }
        public int getSpeed()
        {
            return TopSpeed;
        }
        public void setDescription(string description)
        {
            Description = description;
        }
        public string getDescription()
        {
            return Description;
        }
    }
}
