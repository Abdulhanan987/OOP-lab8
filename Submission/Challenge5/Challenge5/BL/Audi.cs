using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Audi : Car
    {
        private int TopSpeed;
        private bool Ligths;
       

        public Audi(int speed, string color, string model, float price) : base(color, model, price)
        {
            TopSpeed = speed;
        }
        public void SetSpeed(int speed)
        { TopSpeed = speed; }
        public int getSpeed() { return TopSpeed; }
        public float FuelCalculation()
        {
            float var;
            var = TopSpeed / 30;
            return var;

        }
        public bool getLigthState()
        { return Ligths; }
        public void setLigthOn()
        {
            Ligths = true;
        }
        public void setLigthsOff()
        {
            Ligths = false;
        }
    }
}
