using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Bicycle
    {
        protected int Cadence;
        protected int Gear;
        protected int Speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.Cadence = cadence;
            this.Gear = gear;
           this. Speed = speed;
        }
        public void setCadence(int cadence)
        {
            this.Cadence = cadence;
        }
        public void setGear(int gear) {  this.Gear = gear; }
        public void setSpeed(int speed)
        {
            this.Speed += speed;
        }
        public void applyBrake(int brake)
        {
            this.Speed-=brake;
        }
        public int getSpeed()
        {
            return this.Speed;
        }
        public int getGear()
        {
            return this.Gear;
        }
        public int getCadence()
        {
            return this.Cadence;
        }
    }
}
