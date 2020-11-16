using System;
using System.Collections.Generic;
using System.Linq;
using Week_5_CSharp_Codes.Trucks;
using Week_5_CSharp_Codes.People;
using System.Data;
using Week_5_CSharp_Codes.Vehicles;
//using Week_5_CSharp_Codes.Vehicles;
using Week_5_CSharp_Codes.Vehicles.Enums;
using Week_5_CSharp_Codes.Vehicles.Interfaces;

namespace Week_5_CSharp_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string student = "John Smith";
            char firstChar = student[0];

            Console.WriteLine("First character: {0}", firstChar);

            // Dictinay in C#

            var animals = new List<string>();
            animals.Add(item: "Lion");
            animals.Add(item: "Tiger");
            animals.Add(item: "Bird");
            animals.Add(item: "Cat");
            animals.Add(item: "Dog");
            animals.Add(item: "Leopard");

            string favoriteAnimal = "Bird";

            foreach(string animal in animals)
            {
                Console.WriteLine(animal);
            }

            if (animals.Contains(favoriteAnimal))
            {
                Console.WriteLine("I love {0} and also every other animal");

                Console.WriteLine("I love " + favoriteAnimal + " and also ...");
            }
            else
            {
                Console.WriteLine("I don't care ...");
            }

            // Dictional looping
            var person = new Dictionary<string, int>();
            person.Add("John", 23);
            person.Add("Daniel", 42);
            person.Add("Anna", 34);

            for (int i = 0; i< person.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", person.Keys.ElementAt(i), person[person.Keys.ElementAt(i)]);
            }

            foreach(KeyValuePair<string, int> peep in person)
            {
                Console.WriteLine("Name: {0}, Age: {1}", peep.Key, peep.Value);
            }

            var studentData = new Dictionary<string, string>();
            studentData["name"] = "Fred";
            studentData["age"] = "23";
            studentData["hometown"] = "Seatle";
            studentData["favorite_food"] = "Pizza";

            Console.WriteLine("This is {0}", studentData["name"]);
            Console.WriteLine("He is {0} years old", studentData["age"]);
            Console.WriteLine("From {0}", studentData["hometown"]);
            Console.WriteLine("Favorite food is {0}", studentData["favorite_food"]);

            var students = new Dictionary<string, Dictionary<string, string>>();
            students["Fred"] = new Dictionary<string, string>();
            students["Fred"].Add("name", "Fred");
            students["Fred"].Add("age", "23");
            students["Fred"].Add("hometown", "Seatle");
            students["Fred"].Add("favorite_food", "Pizza");

            Console.WriteLine("This is {0}", students["Fred"]["name"]);

            // Importing classes from namespaces
            var audi = new Car();
            var fordF150 = new Truck();     //the namespace is imported at the top

            // Testing the classes created
            var students2 = new Dictionary<string, Student>();
            var someStudent = new Student(name:"Fred", age:20, hometown:"Seatle", favoriteFood:"Pizza");
            students2.Add("Fred", someStudent);

            var anotherStudent = new Student(name: "Sally", age: 23, hometown: "Greensboro", favoriteFood: "Banku");
            students2.Add("Sally", anotherStudent);
            //var studentWithNoData = new Student();

            List<string> someList = null;
            // some other code here
            //...

            var car = new Car();
            car.color = "blue";
            car.Number_Of_Doors = 4;
            car.Start();
            car.Stop();
            car.Number_Of_Doors = 6;
            car.Speed = 65;
            int maxDoors = Car.MAX_DOORS;
            var MaxDoors = CarDoors.MAX_DOORS;
            //car.Drive();   // That class function cannot be accessed because it is private
            Console.WriteLine(car.ToString());

            var sedan = new Car();
            sedan.color = "blue";
            sedan.Number_Of_Doors = 4;
            //sedan.wheelDrive = 2;   // That attribute/parameter is private and restricted for setting it, but can get it
          
            bool comp = Car.Compare(x:sedan, y:new Car());
            Console.WriteLine("Compare: {0}", comp);

            int[] myList = {1,2,3,4,5,6};

            Console.WriteLine("My List: ", myList);

            var vehicle_1 = new List<Car>();
            vehicle_1.Add(item: car);
            vehicle_1.Add(item: sedan);

            var opel = new Vehicle();
            var kia = new Vehicle();
            var vehicle_2 = new List<Vehicle>();
            vehicle_2.Add(item: opel);
            vehicle_2.Add(item: kia);

            var vehicle_3 = new List<IVehicle>();
            //vehicle_3.Add(item: car);
            //vehicle_3.Add(item: sedan);

        }

        static void SomeNonReturningFunction()
        {

        }

        static int SomeReturningFunction(int a)
        {
            return a;
        }


    }
}
