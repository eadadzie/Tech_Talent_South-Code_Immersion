using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_CSharp_Codes.Vehicles.Interfaces
{
    interface IVehicle
    {
        void ChangeGear(int newGear);

        void Acceleration(int increment);

        void Brake(int decrement);
    }
}
