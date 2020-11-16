using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Week_5_CSharp_Codes.Vehicles.Interfaces;
using Week_5_CSharp_Codes.Vehicles;

namespace Week_5_CSharp_Codes.Vehicles
{
    public class Car 
    {
        private int numberOfDoors;
        private int speed;
        private int currentRPM;

        public const string TYPE_SPORTY = "Sporty";
        public const string FAMILY = "Family";
        public const int MAX_DOORS = 6;
        public const int MIN_DOORS = 1;

        public string color; //{ get; private set; }
        public int Number_Of_Doors { 
            get { return numberOfDoors; }
            set{
                if (numberOfDoors >= 1 && numberOfDoors <= 6)
                {
                    this.numberOfDoors = 2;
                }
                }
        }

        public int wheelDrive { get; private set; } = 2; // this attribute has been made private for setting it, but public to get it 

        public Car()
        {
            color = "blue";
            wheelDrive = 4;
        }

        public void Start()
        {
            Console.WriteLine("Car starting");
        }

        // function stop() in javascript
        public void Stop()
        {
            Console.WriteLine("Car stopping");
        }

        private void Drive()   // this method have been made private for class use only
        {
            Console.WriteLine("Driving car");
        }

        // Overiding base Classes and Methods
        public override string ToString()
        {
            //return base.ToString();
            return $"{color}, {speed}, {currentRPM}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static bool Compare(Car x, Car y)
        {
            if (x.color.Equals(y.color) && x.numberOfDoors.Equals(y.numberOfDoors))
            {
                return true;
            }

            return false;
        }

        private int ShiftUp(int a)
        {
            return a;  //Console.WriteLine("Do something");
        }

        private int calculateRPM(int speed)
        {
            int rpm = 0;
            rpm = speed * 2;
            return rpm;
        }

        public int Speed
        {
            get { return speed;}
            set
            {
                speed = value;
                currentRPM = calculateRPM(speed);
            }
        }
    }
}
