using System;

namespace CSharpDataTypes.Vehicles
{
    public class Car
    {
        /// <summary>
        /// Gets or sets the color for the car
        /// </summary>
        public string Color { get; private set; }
        public int NumberOfDoors { get; private set; }
        public int CurrentGear { get; private set; } = 1;

        public int CurrentRPM { get; set; }

        private int speed;

        public int Speed {
            private get { return speed; }
            set { }
        }

        // no-arg constructor
        public Car()
        {
            Color = "White";
            NumberOfDoors = 2;
        }

        // constructor with arguments
        public Car(string color, int numberOfDoors)
        {
            this.Color = color;
            this.NumberOfDoors = numberOfDoors;
        }

        // constructor with a single argument
        public Car(string color)
        {
            this.Color = color;
            NumberOfDoors = 4;
        }

        // function stop() in javascript
        public void Stop()
        {
            Console.WriteLine("Car stopping");
            Drive();
        }

        public void Start()
        {
            Console.WriteLine("Car starting");
        }

        public void Drive()
        {
            Console.WriteLine("Car driving");
            int currentGear = ShiftUp();
        }

        /// <summary>
        /// Compares the properties of two cars
        /// If the properties are all the same, returns true
        /// If the properties are different, returns false
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>true if properties are the same, false otherwise</returns>
        public static bool Compare(Car x, Car y)
        {
            if (x.Color == y.Color && x.NumberOfDoors == y.NumberOfDoors)
            {
                return true;
            }
            return false;
        }

        private int ShiftUp()
        {
            return ++CurrentGear;
        }

        private int ShiftDown()
        {
            if (CurrentGear == 1) {
                return CurrentGear;
            }
            // otherwise subtract 1 off the gear and return the new gear
            return --CurrentGear;
        }

    }
}
