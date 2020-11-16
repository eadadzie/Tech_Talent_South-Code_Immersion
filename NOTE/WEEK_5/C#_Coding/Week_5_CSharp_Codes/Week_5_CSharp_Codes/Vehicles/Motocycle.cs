using System;
using System.Collections.Generic;
using System.Text;
using Week_5_CSharp_Codes.Vehicles.Interfaces;

namespace Week_5_CSharp_Codes
{
    class Motocycle 
    {
        private int speed;
        private int gear;

        public void acceleration(int increment)
        {
            speed += increment;
        }

        public void brake(int increment)
        {
            speed -= increment;
        }

        public void Gear(int increment)
        {
            speed += increment;
        }
    }
}
