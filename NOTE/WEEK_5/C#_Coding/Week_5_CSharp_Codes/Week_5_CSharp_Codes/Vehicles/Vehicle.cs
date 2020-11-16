using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_CSharp_Codes.Vehicles
{
    class Vehicle
    {
        public int doors { get; set; } = 4;

        public int Speeds(int speed)
        {
            return speed * doors;
        }
    }
}
