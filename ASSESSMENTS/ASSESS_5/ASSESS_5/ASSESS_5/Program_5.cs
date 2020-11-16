using System;

namespace ASSESS_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dadzie = new FinanceEmployee("Emma", "Ghana");

            Console.WriteLine($"Department - {dadzie.GetDepartment()}, Name - {dadzie.GetName()}, Location - {dadzie.GetLocation()}");
            Console.WriteLine($"Is {dadzie.GetName()} on vacation? {dadzie.IsOnVacation}"); 
        }
    }

    abstract class Employee
    {
        public string Department;
        public string Name;
        public string Location;
        public bool IsOnVacation = false;

        public Employee(string type, string name, string location)
        {
            Department = type;
            Name = name;
            Location = location;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetLocation()
        {
            return Location;
        }

        public bool GetStatus()
        {
            return IsOnVacation;
        }

        public bool SwitchStatus()
        {
            if (IsOnVacation == false)
            {
                return IsOnVacation = true;
            }
            else
            {
                return IsOnVacation = false;
            }
        }
    }


    class FinanceEmployee : Employee
    {

        //public string Department {get; private set;} = "Finance";

        public FinanceEmployee(string name, string location, string department = "Finance") : base(department, name, location)
        {

        }
    }


    class MarketingEmployee : Employee
    {

        // public string Department {get; private set;} = "Marketing";

        public MarketingEmployee(string name, string location, string department = "Marketing") : base(department, name, location)
        {

        }
    }
}
