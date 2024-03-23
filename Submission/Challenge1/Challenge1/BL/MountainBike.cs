using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class MountainBike : Bicycle
    {
        private int seatHeigth;
        public MountainBike(int heigth,int cadence, int gear, int speed) : base(cadence, gear, speed)
        {
            this.seatHeigth = heigth;
        }
        public void setHeigth(int heigth)
        {
            this.seatHeigth = heigth;
        }
        public int getHeigth()
        {
            return this.seatHeigth;
        }
    }
}
